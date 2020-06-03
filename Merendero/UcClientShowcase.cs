using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Merendero
{
    public partial class UcClientShowcase : UserControl
    {
        #region FIELDS
        private FrmMerendero parent;
        //list with new bookings pending to be booked assigned to the client
        private List<ClsBooking> ListNewBookings; 
        //list with products menu which are the same name of booked onces
        private List<ClsBooking> ListTypeBookings;
        //dictionary containing amounts booked per product name (menu)
        private Dictionary<string, int> DictProductsBooked;

        //temps
        private UcProduct SelectedProduct;
        #endregion

        #region CONSTRUCTOR
        public UcClientShowcase(FrmMerendero _parent)
        {
            InitializeComponent();
            Size = new Size(FrmMerendero.UCWIDTH, FrmMerendero.UCHEIGHT);
            Location = new Point(FrmMerendero.X, FrmMerendero.Y);
            ListNewBookings = new List<ClsBooking>();
            ListTypeBookings = new List<ClsBooking>();
            DictProductsBooked = new Dictionary<string, int>();
            parent = _parent;
            SelectedProduct = null;
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Procedure - update showcase with menu products
        /// </summary>
        public void FillList()
        {
            FlpnlProducts.Controls.Clear();
            ListNewBookings.Clear();
            ListTypeBookings.Clear();
            DictProductsBooked.Clear();
            ClsAccount.GetProducts();
            parent.Client.GetBookings();

            foreach (UcProduct p in ClsAccount.ListMenu)
            {
                p.NudAmount.Maximum = ClsAccount.DictAmounts[p.Name];

                if (parent.Client.DictUnbookableAmounts.ContainsKey(p.Name))
                    p.NudAmount.Maximum -= parent.Client.DictUnbookableAmounts[p.Name];

                if (p.NudAmount.Maximum <= 0)
                {
                    p.BtnOk.Enabled = false;
                    p.LblCost.Text = "FINITO";

                    p.Click -= p.SwitchSide;
                    p.LblName.Click -= p.SwitchSide;
                    p.PbxImage.Click -= p.SwitchSide;
                    p.RtbxDescription.Click -= p.SwitchSide;
                    p.LblCost.Click -= p.SwitchSide;
                }
                else
                {
                    p.Click += OneProductShowed_Click;
                    p.LblName.Click += OneProductShowed_Click;
                    p.PbxImage.Click += OneProductShowed_Click;
                    p.RtbxDescription.Click += OneProductShowed_Click;
                    p.LblCost.Click += OneProductShowed_Click;
                    p.BtnOk.Click += Amount_Click;
                }

                FlpnlProducts.Controls.Add(p);
            }
        }

        /// <summary>
        /// Procedure - clear product events left in controls
        /// </summary>
        public void ClearProductEvents()
        {
            foreach (UcProduct p in ClsAccount.ListMenu)
            {
                p.Click -= OneProductShowed_Click;
                p.LblName.Click -= OneProductShowed_Click;
                p.PbxImage.Click -= OneProductShowed_Click;
                p.RtbxDescription.Click -= OneProductShowed_Click;
                p.LblCost.Click -= OneProductShowed_Click;
                p.BtnOk.Click -= Amount_Click;
            }
        }

        /// <summary>
        /// Procedure - handle amount of product selectable
        /// </summary>
        /// <param name="_product">product object</param>
        private void AmountHandler(UcProduct _product)
        {
            int amount = (int)_product.NudAmount.Value;
            _product.NudAmount.Maximum = _product.NudAmount.Maximum - amount;
            SelectedProduct.SwitchSide(SelectedProduct, EventArgs.Empty);
            List<UcProduct> list = ClsAccount.ListProducts.FindAll(x => x.Name == _product.Name && x.Booking == null).GetRange(0, amount);

            foreach (UcProduct p in list)
                ListNewBookings.Add(new ClsBooking(
                    parent.Client.Name,
                    p.Id
                    ));

            ListTypeBookings.Add(new ClsBooking(
                parent.Client.Name,
                _product.Id
                ));

            string name = (ClsAccount.ListProducts.Find(x => x.Id == _product.Id).Name);
            DictProductsBooked[name] = amount;
        }

        /// <summary>
        /// Procedure - handle product cover show
        /// </summary>
        /// <param name="_product">product object</param>
        private void OneShowedHandler(UcProduct _product)
        {
            if (SelectedProduct != null && _product.Id != SelectedProduct.Id && SelectedProduct.Clicked)
            {
                SelectedProduct.SwitchSide(SelectedProduct, EventArgs.Empty);
                SelectedProduct = null;
            }

            SelectedProduct = _product;
        }

        /// <summary>
        /// Procedure - confirm booking, show receipt and add bookings to database
        /// </summary>
        private void ConfirmBookings()
        {
            if (ListTypeBookings.Count == 0) return;

            FrmReceipt frmReceipt = new FrmReceipt(ListTypeBookings, DictProductsBooked);
            DialogResult dr = frmReceipt.ShowDialog();

            if (dr == DialogResult.OK)
            {
                foreach (ClsBooking b in ListNewBookings)
                    parent.Client.Book(b);
            }

            ClearProductEvents();
            FillList();
        }
        #endregion

        #region EVENTS
        public void OneProductShowed_Click(object sender, EventArgs e)
        {
            if (sender is UcProduct)
                OneShowedHandler((UcProduct)sender);
            else if (sender is Label)
                OneShowedHandler((UcProduct)((Label)sender).Parent);
            else if(sender is PictureBox)
                OneShowedHandler((UcProduct)((PictureBox)sender).Parent);
            else if(sender is RichTextBox)
                OneShowedHandler((UcProduct)((RichTextBox)sender).Parent);
        }

        public void Amount_Click(object sender, EventArgs e)
        {
            AmountHandler((UcProduct)((Button)sender).Parent);
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmBookings();
        }
        #endregion
    }
}

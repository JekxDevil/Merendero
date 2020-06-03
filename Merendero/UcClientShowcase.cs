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
        private FrmMerendero parent;
        private UcProduct SelectedProduct;
        private List<ClsBooking> ListNewBookings; 
        private List<ClsBooking> ListTypeBookings;
        private Dictionary<string, int> DictProductsBooked;

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

        #region METHODS
        public void FillList()
        {
            FlpnlProducts.Controls.Clear();
            ListNewBookings.Clear();
            ListTypeBookings.Clear();
            DictProductsBooked.Clear();

            foreach (UcProduct p in ClsAccount.ListMenu)
            {
                p.NudAmount.Maximum = ClsAccount.DictAmounts[p.Name];

                if (parent.Client.DictUnbookableAmounts.ContainsKey(p.Name))
                    p.NudAmount.Maximum -= parent.Client.DictUnbookableAmounts[p.Name];

                if (p.NudAmount.Maximum <= 0)
                    p.LblCost.Text = "FINITO";

                p.Click += OneProductShowed_Click;
                p.LblName.Click += OneProductShowed_Click;
                p.PbxImage.Click += OneProductShowed_Click;
                p.RtbxDescription.Click += OneProductShowed_Click;
                p.LblCost.Click += OneProductShowed_Click;
                p.BtnOk.Click += Amount_Click;
                FlpnlProducts.Controls.Add(p);
            }
        }

        private void AmountHandler(UcProduct _product)
        {
            int amount = (int)_product.NudAmount.Value;
            _product.NudAmount.Maximum = _product.NudAmount.Maximum - amount;
            SelectedProduct.SwitchSide(SelectedProduct, EventArgs.Empty);
            List<UcProduct> list = ClsAccount.ListProducts.FindAll(x => x.Name == _product.Name && !x.Booked).GetRange(0, amount);

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

        private void OneShowedHandler(UcProduct _product)
        {
            if (SelectedProduct != null && _product.Id != SelectedProduct.Id && SelectedProduct.Clicked)
            {
                SelectedProduct.SwitchSide(SelectedProduct, EventArgs.Empty);
                SelectedProduct = null;
            }

            SelectedProduct = _product;
        }

        private void ConfirmBookings()
        {
            if (ListTypeBookings.Count == 0) return;

            FrmReceipt frmReceipt = new FrmReceipt(ListTypeBookings, DictProductsBooked);
            DialogResult dr = frmReceipt.ShowDialog();

            if (dr == DialogResult.OK)
                foreach (ClsBooking b in ListNewBookings)
                    parent.Client.Book(b);
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

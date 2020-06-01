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
    public partial class UcShowcase : UserControl
    {
        private FrmMerendero parent;
        private UcProduct SelectedProduct;
        private List<ClsBooking> ListBookings;

        public UcShowcase(FrmMerendero _parent)
        {
            InitializeComponent();
            Size = new Size(FrmMerendero.UCWIDTH, FrmMerendero.UCHEIGHT);
            Location = new Point(FrmMerendero.X, FrmMerendero.Y);
            parent = _parent;
            SelectedProduct = null;
        }

        #region METHODS
        public void FillList()
        {
            FlpnlProducts.Controls.Clear();

            foreach (UcProduct p in ClsAccount.ListMenu)
            {
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

            for (int i = 0; i < amount; i++)
                ListBookings.Add(new ClsBooking(
                    parent.Client.Name,
                    _product.Id
                    ));
        }

        private void OneShowedHandler(UcProduct _product)
        {
            //condizione sbagliata
            if (SelectedProduct != null && _product.Id != SelectedProduct.Id && SelectedProduct.Clicked)
            {
                SelectedProduct.SwitchSide(SelectedProduct, EventArgs.Empty);
                SelectedProduct = null;
            }

            SelectedProduct = _product;
        }

        private void ConfirmBookings()
        {
            if (ListBookings.Count == 0) return;
            FrmReceipt frmReceipt = new FrmReceipt(ListBookings);
            DialogResult dr = frmReceipt.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //apri form scontrino, visualizza e conferma, dopo dialogresult ok effettua prenotazione
                foreach (ClsBooking b in parent.Client.ListBookings)
                    parent.Client.Book(b);
            }
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

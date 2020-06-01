using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merendero
{
    public partial class UcShowcase : UserControl
    {
        private FrmMerendero parent;
        private static UcAmountProduct ucAmount;
        private static UcProduct SelectedProduct;

        public UcShowcase(FrmMerendero _parent)
        {
            InitializeComponent();
            Size = new Size(FrmMerendero.UCWIDTH, FrmMerendero.UCHEIGHT);
            Location = new Point(FrmMerendero.X, FrmMerendero.Y);
            parent = _parent;
            ucAmount = new UcAmountProduct() { Visible = false };
            ucAmount.Click += Amount_Click;
            FlpnlProducts.Controls.Add(ucAmount);       //bug
            SelectedProduct = null;
        }

        #region METHODS
        private static void SelectedHandler(UcProduct _product)
        {
            if (_product.Clicked)
            {
                ucAmount.Visible = false;
                _product.BringToFront();
            }
            else
            {
                SelectedProduct = _product;
                ucAmount.Location = _product.Location;
                ucAmount.Visible = true;
                ucAmount.BringToFront();
            }

            _product.Clicked = _product.Clicked ? false : true;
        }

        public void FillList()
        {
            FlpnlProducts.Controls.Clear();

            foreach(UcProduct p in ClsAccount.ListMenu)
                FlpnlProducts.Controls.Add(p);
        }

        private void ConfirmBookings()
        {
            //apri form scontrino, visualizza e conferma, dopo dialogresult ok effettua prenotazione

            foreach (ClsBooking b in parent.Client.ListBookings)
                parent.Client.Book(b);
        }

        private void AmountHandler()
        {

        }
        #endregion

        #region EVENTS
        public static void Product_Click(object sender, EventArgs e)
        {
            SelectedHandler((UcProduct)sender);
        }

        private void Amount_Click(object sender, EventArgs e)
        {
            AmountHandler();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmBookings();
        }
        #endregion
    }
}

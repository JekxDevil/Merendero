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
        FrmMerendero parent;
        UcProduct SelectedProduct;

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

            foreach(UcProduct p in ClsAccount.ListMenu)
                FlpnlProducts.Controls.Add(p);
        }

        private void ConfirmBookings()
        {
            
        }

        private void SelectedHandler()
        {
            SelectedProduct = null;
        }
        #endregion

        #region EVENTS
        public static void Product_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmBookings();
        }
        #endregion
    }
}

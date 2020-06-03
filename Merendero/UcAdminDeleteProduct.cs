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
    public partial class UcAdminDeleteProduct : UserControl
    {
        #region FIELDS
        private FrmMerendero parent;
        #endregion

        #region CONSTRUCTORS
        public UcAdminDeleteProduct(FrmMerendero _parent)
        {
            InitializeComponent();
            Size = new Size(FrmMerendero.UCWIDTH, FrmMerendero.UCHEIGHT);
            Location = new Point(FrmMerendero.X, FrmMerendero.Y);
            parent = _parent;
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Procedure - fill listview menu with products
        /// </summary>
        public void FillList()
        {
            LvwProducts.Items.Clear();
            ListViewItem lvi;

            foreach(UcProduct p in ClsAccount.ListMenu)
            {
                lvi = new ListViewItem(p.Name);
                lvi.SubItems.Add(p.Tag.ToString());
                lvi.SubItems.Add(p.Cost.ToString("c2"));
                lvi.SubItems.Add(p.Category.ToString());
                lvi.SubItems.Add(ClsAccount.DictAmounts[p.Name].ToString());
                LvwProducts.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Procedure - delete selected product from database
        /// </summary>
        private void DeleteProduct()
        {
            if (LvwProducts.FocusedItem == null) return;

            DialogResult dr = MessageBox.Show("Eliminare il prodotto dal menu e tutte le prenotazioni associate?",
                "Eliminazione prodotto dal menu",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
                );

            if (dr == DialogResult.OK)
            {
                int index = LvwProducts.FocusedItem.Index;
                parent.Admin.DeleteProduct(ClsAccount.ListMenu[index]);
                FillList();
            }
        }
        #endregion

        #region EVENTS
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }
        #endregion
    }
}

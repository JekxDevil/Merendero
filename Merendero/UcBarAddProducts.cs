﻿using System;
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
    public partial class UcBarAddProducts : UserControl
    {
        #region FIELDS
        private FrmMerendero parent;
        #endregion

        #region CONSTRUCTOR
        public UcBarAddProducts(FrmMerendero _parent)
        {
            InitializeComponent();
            Size = new Size(FrmMerendero.UCWIDTH, FrmMerendero.UCHEIGHT);
            Location = new Point(FrmMerendero.X, FrmMerendero.Y);
            parent = _parent;
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Procedure - fill listview with menu products
        /// </summary>
        public void FillList()
        {
            LvwProducts.Items.Clear();
            ListViewItem lvi;

            foreach(UcProduct p in ClsAccount.ListMenu)
            {
                lvi = new ListViewItem(p.Name);
                lvi.SubItems.Add(p.Cost.ToString("c2"));
                lvi.SubItems.Add(p.Category.ToString());
                lvi.SubItems.Add((ClsAccount.DictAmounts[p.Name] - parent.Bar.DictUnbookableAmounts[p.Name]).ToString());
                LvwProducts.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Procedure - add products to the bar pantry
        /// </summary>
        private void AddProducts()
        {
            if (LvwProducts.FocusedItem == null) return;

            int index = LvwProducts.FocusedItem.Index;
            parent.Bar.FillPantry(ClsAccount.ListMenu[index], (int)NudAmount.Value);
            FillList();
        }

        /// <summary>
        /// Procedure - update selected product label
        /// </summary>
        private void SelectedProduct()
        {
            if (LvwProducts.FocusedItem == null) return;

            LblSelectedProduct.Text = ClsAccount.ListMenu[LvwProducts.FocusedItem.Index].Name;
        }
        #endregion

        #region EVENTS
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            AddProducts();
        }

        private void LvwProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedProduct();
        }
        #endregion
    }
}

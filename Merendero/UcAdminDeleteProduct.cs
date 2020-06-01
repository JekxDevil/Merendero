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
    public partial class UcAdminDeleteProduct : UserControl
    {
        private FrmMerendero parent;

        public UcAdminDeleteProduct(FrmMerendero _parent)
        {
            InitializeComponent();
            Size = new Size(FrmMerendero.UCWIDTH, FrmMerendero.UCHEIGHT);
            Location = new Point(FrmMerendero.X, FrmMerendero.Y);
            parent = _parent;
        }

        #region METHODS
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

        private void DeleteProduct()
        {
            if (LvwProducts.FocusedItem == null) return;
            
            int index = LvwProducts.FocusedItem.Index;
            parent.Admin.DeleteProduct(ClsAccount.ListProducts[index]);
            FillList();
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
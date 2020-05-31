using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Merendero
{
    public partial class UcAdminAddProduct : UserControl
    {
        private FrmMerendero parent;

        public UcAdminAddProduct(FrmMerendero _parent)
        {
            InitializeComponent();
            Size = new Size(FrmMerendero.UCWIDTH, FrmMerendero.UCHEIGHT);
            Location = new Point(FrmMerendero.X, FrmMerendero.Y);
            FillCategories();
            parent = _parent;
            CbxCategory.SelectedIndex = 0;
            BtnFile.Tag = false;        //check if image was submitted
        }

        #region METHODS
        public void FillList()
        {
            LvwProducts.Items.Clear();
            ListViewItem lvi;

            foreach (UcProduct p in ClsAccount.ListMenu)
            {
                lvi = new ListViewItem(p.Name);
                lvi.SubItems.Add(p.Description);
                lvi.SubItems.Add(p.Cost.ToString("c2"));
                lvi.SubItems.Add(p.Category.ToString());
                LvwProducts.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Procedure - fill product categories
        /// </summary>
        private void FillCategories()
        {
            foreach (string s in Enum.GetNames(typeof(UcProduct.EnCategory)))
                CbxCategory.Items.Add(s);
        }

        private void SelectFile()
        {
            OpenFileDialog ofd = new OpenFileDialog() {
                Title = "Apri immagine",
                Filter = "File PNG (*png)|*.png" +
                "|File JPG (*.jpg, *.jpeg)|*.jpg;*.jpeg" +
                "|Tutti i file (*.*)|*.*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LblPath.Text = ofd.FileName;
                    PbxPreviewProduct.Image = Image.FromFile(ofd.FileName);
                    BtnFile.Tag = true;
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Impossibile caricare il file: " + ex.Message);
                }
            }

            ofd.Dispose();
        }

        /// <summary>
        /// Procedure - add product and update list
        /// </summary>
        private void AddProduct()
        {
            if (String.IsNullOrWhiteSpace(TbxName.Text)) return;
            if (String.IsNullOrWhiteSpace(RtbxDescription.Text)) return;


            UcProduct p = new UcProduct(
                TbxName.Text.ToLower().Trim(),
                LblPath.Text,
                RtbxDescription.Text,
                (float)NudCost.Value,
                (UcProduct.EnCategory)CbxCategory.SelectedIndex
                );

            parent.Admin.AddProduct(p);
            FillList();

            //good feeback
            LblPath.Text = "Prodotto aggiunto con successo.";
            TbxName.Text = null;
            PbxPreviewProduct.Image = null;
            RtbxDescription.Text = null;
            NudCost.Value = NudCost.Minimum;
            CbxCategory.SelectedIndex = 0;
            BtnFile.Tag = false;
        }

        private void EditProduct()
        {
            if (LvwProducts.FocusedItem == null) return;
            if (String.IsNullOrWhiteSpace(TbxName.Text)) return;
            if (String.IsNullOrWhiteSpace(RtbxDescription.Text)) return;

            UcProduct p = new UcProduct(
                TbxName.Text.ToLower().Trim(),
                LblPath.Text,
                RtbxDescription.Text,
                (float)NudCost.Value,
                (UcProduct.EnCategory)CbxCategory.SelectedIndex
                );

            if ((bool)BtnFile.Tag)
            {
                string image = (string)ClsAccount.ListMenu[LvwProducts.FocusedItem.Index].Tag;
                parent.Admin.EditProduct(p, image);
            }
            else
                parent.Admin.EditProduct(p);

            FillList();

            //good feeback
            LblPath.Text = "Prodotto modificato con successo.";
            TbxName.Text = null;
            PbxPreviewProduct.Image = null;
            RtbxDescription.Text = null;
            NudCost.Value = NudCost.Minimum;
            CbxCategory.SelectedIndex = 0;
            BtnFile.Tag = false;
        }

        private void CompileField()
        {
            if (LvwProducts.FocusedItem == null) return;

            UcProduct product = ClsAccount.ListMenu[LvwProducts.FocusedItem.Index];
            TbxName.Text = product.Name;
            RtbxDescription.Text = product.Description;
            NudCost.Value = Convert.ToDecimal(product.Cost);
            CbxCategory.SelectedIndex = (int)product.Category;
            LblPath.Text = (string)product.Tag;
            PbxPreviewProduct.Image = product.Image;
        }
        #endregion

        #region EVENTS
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditProduct();
        }

        private void LvwProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompileField();
        }
        #endregion
    }
}

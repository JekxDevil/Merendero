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
    public partial class UcAdminAccounts : UserControl
    {
        FrmMerendero parent;

        public UcAdminAccounts(FrmMerendero _parent)
        {
            InitializeComponent();
            Size = new Size(FrmMerendero.UCWIDTH, FrmMerendero.UCHEIGHT);
            Location = new Point(FrmMerendero.X, FrmMerendero.Y);
            FillTypes();
            parent = _parent;
            CbxType.SelectedIndex = 0;
        }

        #region METHODS
        /// <summary>
        /// Procedure - fill the listview with user credentials
        /// </summary>
        public void FillList()
        {
            LvwAccounts.Items.Clear();
            ListViewItem lvi;

            foreach(ClsAccount a in parent.Admin.ListAccounts)
            {
                lvi = new ListViewItem(a.Name);
                lvi.SubItems.Add(a.Password);
                lvi.SubItems.Add(a.Type.ToString());
                LvwAccounts.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Procedure - let the admin to create a new account
        /// </summary>
        private void AddAccount()
        {
            if (String.IsNullOrWhiteSpace(TbxName.Text)) return;
            if (String.IsNullOrWhiteSpace(TbxPassword.Text)) return;

            parent.Admin.AddAccount(new ClsAccount(
                TbxName.Text,
                TbxPassword.Text,
                (ClsAccount.EnType)CbxType.SelectedIndex
                ));
            FillList();
        }

        /// <summary>
        /// Procedure - let the admin to edit accounts
        /// </summary>
        private void EditAccount()
        {
            if (LvwAccounts.FocusedItem == null) return;
            if (String.IsNullOrWhiteSpace(TbxName.Text)) return;
            if (String.IsNullOrWhiteSpace(TbxPassword.Text)) return;

            parent.Admin.EditAccount(new ClsAccount(
                TbxName.Text,
                TbxPassword.Text,
                (ClsAccount.EnType)CbxType.SelectedIndex
                ));
            FillList();
        }

        /// <summary>
        /// Procedure - let the admin to delete new account (Be carefull)
        /// </summary>
        private void DeleteAccount()
        {
            if (LvwAccounts.FocusedItem == null) return;
            if (parent.Admin.Name == parent.Admin.ListAccounts[LvwAccounts.FocusedItem.Index].Name) return; //cannot remove himself

            parent.Admin.DeleteAccount(parent.Admin.ListAccounts[LvwAccounts.FocusedItem.Index]);
            FillList();
        }

        private void CompileField()
        {
            if (LvwAccounts.FocusedItem == null) return;

            ClsAccount account = parent.Admin.ListAccounts[LvwAccounts.FocusedItem.Index];
            TbxName.Text = account.Name;
            TbxPassword.Text = account.Password;
            CbxType.SelectedIndex = (int)account.Type;
        }

        private void FillTypes()
        {
            foreach (string s in Enum.GetNames(typeof(ClsAccount.EnType)))
                CbxType.Items.Add(s);
        }
        #endregion

        #region EVENTS
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddAccount();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditAccount();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteAccount();
        }

        private void LvwAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompileField();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Merendero
{
    public partial class UcLogin : UserControl
    {
        private const char HIDE = '*';
        private const char SHOW = '\0';

        FrmMerendero parent;

        public UcLogin(FrmMerendero _parent)
        {
            InitializeComponent();
            Size = new Size(FrmMerendero.UCWIDTH, FrmMerendero.UCHEIGHT);
            Location = new Point(FrmMerendero.X, FrmMerendero.Y);
            BtnHidePassword.BackgroundImage = global::Merendero.Properties.Resources.eye_closed;
            BtnHidePassword.Tag = true;
            TbxPassword.PasswordChar = HIDE;
            parent = _parent;
        }

        #region METHODS
        private void UnsubscribeButtonEvents()
        {
            if(parent.Admin != null)
            {
                parent.Btn1.Click -= OpenAdminAddProduct;
                parent.Btn2.Click -= OpenAdminDeleteProduct;
                parent.Btn3.Click -= OpenAdminAccounts;
            }
            else if(parent.Bar != null)
            {
                parent.Btn1.Click -= OpenBarAddProduct;
            }
            else if(parent.Client != null)
            {
                parent.Btn1.Click -= OpenShowcase;
            }

            parent.Admin = null;
            parent.Bar = null;
            parent.Client = null;
        }

        private void LogIn()
        {
            if (string.IsNullOrWhiteSpace(TbxUsername.Text)) return;
            if (string.IsNullOrWhiteSpace(TbxPassword.Text)) return;

            string user = TbxUsername.Text;
            string pass = TbxPassword.Text;
            ClsAccount.EnType? type = null;
            
            try
            {
                Program.conn.Open();
                Program.cmd.CommandText = "SELECT type FROM account WHERE name = @user AND password = @pass;";
                Program.cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
                Program.cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
                SqlDataReader reader = Program.cmd.ExecuteReader();
                Program.cmd.Parameters.Clear();

                if (reader.Read())
                {
                    UnsubscribeButtonEvents();
                    type = (ClsAccount.EnType)reader["type"];
                }

                reader.Close();
            }
            catch (SqlException esql)
            {
                MessageBox.Show("Lettura Database fallita: " + esql.Message);
            }
            finally
            {
                Program.conn.Close();
            }

            switch (type)
            {
                case ClsAccount.EnType.ADMIN:
                    //open app management
                    parent.Admin = new ClsAdmin(user, pass);
                    ClsAccount.GetProducts();
                    parent.ucAdminAddProduct.FillList();
                    parent.ucAdminAddProduct.BringToFront();

                    //set button 1
                    parent.Btn1.Text = "Aggiungi Prodotto";
                    parent.Btn1.Visible = true;
                    parent.Btn1.Click += OpenAdminAddProduct;

                    //set button 2
                    parent.Btn2.Text = "Elimina Prodotto";
                    parent.Btn2.Visible = true;
                    parent.Btn2.Click += OpenAdminDeleteProduct;

                    //set button 3
                    parent.Btn3.Text = "Gestione Account";
                    parent.Btn3.Visible = true;
                    parent.Btn3.Click += OpenAdminAccounts;

                    //set button 4
                    parent.Btn4.Visible = false;

                    break;

                case ClsAccount.EnType.BAR:
                    //open bar management
                    parent.Bar = new ClsBar(user, pass);
                    ClsAccount.GetProducts();
                    parent.ucBarAddProduct.FillList();
                    parent.ucBarAddProduct.BringToFront();

                    //set button 1
                    parent.Btn1.Text = "Aggiungi Prodotto";
                    parent.Btn1.Visible = true;
                    parent.Btn1.Click += OpenBarAddProduct;

                    //set button 2
                    parent.Btn2.Visible = false;

                    //set button 3
                    parent.Btn3.Visible = false;

                    //set button 4
                    parent.Btn4.Visible = false;

                    break;

                case ClsAccount.EnType.CLIENT:
                    //open showcase
                    parent.Client = new ClsClient(user, pass);
                    ClsAccount.GetProducts();
                    parent.ucShowcase.BringToFront();

                    //set button 1
                    parent.Btn1.Text = "Vetrina";
                    parent.Btn1.Visible = true;
                    parent.Btn1.Click += OpenShowcase;

                    //set button 2
                    parent.Btn2.Visible = false;

                    //set button 3
                    parent.Btn3.Visible = false;

                    //set button 4
                    parent.Btn4.Visible = false;

                    break;

                default:
                    //no user was found
                    break;
            }

            parent.PnlPanel.Location = new Point(parent.PnlPanel.Location.X, parent.Btn1.Location.Y);
            TbxUsername.Text = TbxPassword.Text = null;
        }

        private void PasswordVisibility()
        {
            if ((bool)BtnHidePassword.Tag)
            {
                TbxPassword.PasswordChar = SHOW;
                BtnHidePassword.BackgroundImage = global::Merendero.Properties.Resources.eye_open;
            }
            else
            {
                TbxPassword.PasswordChar = HIDE;
                BtnHidePassword.BackgroundImage = global::Merendero.Properties.Resources.eye_closed;
            }

            BtnHidePassword.Tag = !(bool)BtnHidePassword.Tag;
        }
        #endregion

        #region EVENTS
        private void OpenAdminAddProduct(object sender, EventArgs e)
        {
            parent.ucAdminAddProduct.BringToFront();
            parent.PnlPanel.Location = new Point(parent.PnlPanel.Location.X, parent.Btn1.Location.Y);
            ClsAccount.GetProducts();
            parent.ucAdminAccounts.FillList();
        }

        private void OpenAdminDeleteProduct(object sender, EventArgs e)
        {
            parent.ucAdminDeleteProduct.BringToFront();
            parent.PnlPanel.Location = new Point(parent.PnlPanel.Location.X, parent.Btn2.Location.Y);
            ClsAccount.GetProducts();
            parent.ucAdminDeleteProduct.FillList();
        }

        private void OpenAdminAccounts(object sender, EventArgs e)
        {
            parent.ucAdminAccounts.BringToFront();
            parent.PnlPanel.Location = new Point(parent.PnlPanel.Location.X, parent.Btn3.Location.Y);
            parent.Admin.GetAccounts();
            parent.ucAdminAccounts.FillList();
        }

        private void OpenBarAddProduct(object sender, EventArgs e)
        {
            parent.ucBarAddProduct.BringToFront();
            parent.PnlPanel.Location = new Point(parent.PnlPanel.Location.X, parent.Btn1.Location.Y);
            ClsAccount.GetProducts();
            parent.ucBarAddProduct.FillList();
        }

        private void OpenShowcase(object sender, EventArgs e)
        {
            parent.ucShowcase.BringToFront();
            parent.PnlPanel.Location = new Point(parent.PnlPanel.Location.X, parent.Btn1.Location.Y);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void BtnHidePassword_Click(object sender, EventArgs e)
        {
            PasswordVisibility();
        }
        #endregion
    }
}

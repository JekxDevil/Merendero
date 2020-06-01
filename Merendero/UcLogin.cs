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
        private void ClearSession()
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
                parent.Btn2.Click -= OpenBarBookings;
            }
            else if(parent.Client != null)
            {
                parent.Btn1.Click -= OpenShowcase;
            }

            parent.Btn1.Visible = parent.Btn2.Visible = parent.Btn3.Visible = false;
            parent.Btn1.Text = parent.Btn2.Text = parent.Btn3.Text = string.Empty;

            parent.Admin = null;
            parent.Bar = null;
            parent.Client = null;
            parent.LblAccount.Text = string.Empty;
        }

        private void LogIn()
        {
            if (string.IsNullOrWhiteSpace(TbxUsername.Text)) return;
            if (string.IsNullOrWhiteSpace(TbxPassword.Text)) return;

            string user = TbxUsername.Text;
            string pass = TbxPassword.Text;
            ClsAccount.EnType? type = ClsAccount.Login(user, pass);
            ClearSession();

            switch (type)
            {
                case ClsAccount.EnType.ADMIN:
                    //open app management
                    parent.Admin = new ClsAdmin(user, pass);
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

                    break;

                case ClsAccount.EnType.BAR:
                    //open bar management
                    parent.Bar = new ClsBar(user, pass);
                    parent.ucBarAddProduct.FillList();
                    parent.ucBarAddProduct.BringToFront();

                    //set button 1
                    parent.Btn1.Text = "Aggiungi Prodotti";
                    parent.Btn1.Visible = true;
                    parent.Btn1.Click += OpenBarAddProduct;

                    //set button 2
                    parent.Btn2.Text = "Prenotazioni";
                    parent.Btn2.Visible = true;
                    parent.Btn2.Click += OpenBarBookings;

                    //set button 3
                    parent.Btn3.Visible = false;

                    break;

                case ClsAccount.EnType.CLIENT:
                    //open showcase
                    parent.Client = new ClsClient(user, pass);
                    parent.ucShowcase.FillList();
                    parent.ucShowcase.BringToFront();

                    //set button 1
                    parent.Btn1.Text = "Vetrina";
                    parent.Btn1.Visible = true;
                    parent.Btn1.Click += OpenShowcase;

                    //set button 2
                    parent.Btn2.Visible = false;

                    //set button 3
                    parent.Btn3.Visible = false;

                    break;

                default:
                    //no user was found
                    MessageBox.Show("Utente o Password errati.");
                    return;
            }

            parent.PnlPanel.Location = new Point(parent.PnlPanel.Location.X, parent.Btn1.Location.Y);
            TbxUsername.Text = TbxPassword.Text = String.Empty;
            parent.LblAccount.Text = user;
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
            parent.ucAdminAddProduct.FillList();
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

        private void OpenBarBookings(object sender, EventArgs e)
        {
            parent.ucBarBookings.BringToFront();
            parent.PnlPanel.Location = new Point(parent.PnlPanel.Location.X, parent.Btn2.Location.Y);
            ClsAccount.GetProducts();
            parent.ucBarBookings.FillClientsList();
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

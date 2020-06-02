using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Merendero
{
    public partial class FrmMerendero : Form
    {
        #region CONSTS
        public const int UCWIDTH = 1058;
        public const int UCHEIGHT = 574;
        public const int X = 159;
        public const int Y = 135;
        public const int BTNHEIGHT = 60;
        public const int BTNWIDTH = 145;
        #endregion

        #region FIELDS
        public ClsAdmin Admin;
        public ClsBar Bar;
        public ClsClient Client;
        public UcLogin ucLogin;
        public UcAdminProductsManagement ucAdminAddProduct;
        public UcAdminDeleteProduct ucAdminDeleteProduct;
        public UcAdminAccounts ucAdminAccounts;
        public UcBarAddProducts ucBarAddProduct;
        public UcBarBookings ucBarBookings;
        public UcClientShowcase ucClientShowcase;
        public UcClientBookings ucClientBookings;

        #endregion

        public FrmMerendero()
        {
            InitializeComponent();
            ucLogin = new UcLogin(this);
            ucAdminAddProduct = new UcAdminProductsManagement(this);
            ucAdminDeleteProduct = new UcAdminDeleteProduct(this);
            ucAdminAccounts = new UcAdminAccounts(this);
            ucBarAddProduct = new UcBarAddProducts(this);
            ucBarBookings = new UcBarBookings(this);
            ucClientShowcase = new UcClientShowcase(this);
            ucClientBookings = new UcClientBookings(this);
            this.Controls.Add(ucLogin);
            this.Controls.Add(ucAdminAddProduct);
            this.Controls.Add(ucAdminDeleteProduct);
            this.Controls.Add(ucAdminAccounts);
            this.Controls.Add(ucBarAddProduct);
            this.Controls.Add(ucBarBookings);
            this.Controls.Add(ucClientShowcase);
            this.Controls.Add(ucClientBookings);
            BtnLogin.Height = PnlPanel.Height = BTNHEIGHT;
            BtnLogin.Width = BTNWIDTH;
            Btn1.Visible = Btn2.Visible = Btn3.Visible = false;
            LblAccount.Text = string.Empty;
            ucLogin.BringToFront();
        }

        #region METHODS
        private void Login()
        {
            ucLogin.BringToFront();
            PnlPanel.Location = new Point(PnlPanel.Location.X, BtnLogin.Location.Y);
        }
        #endregion

        #region EVENTS
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnWebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.iisve.it/pvw/app/ANII0010/pvw_sito.php");
        }

        private void BtnInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/volterraelia/?hl=it");
        }

        private void BtnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/istitutovolterraelia");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        #endregion
    }

}
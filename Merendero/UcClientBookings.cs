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
    public partial class UcClientBookings : UserControl
    {
        #region FIELDS
        private FrmMerendero parent;
        #endregion

        #region CONSTRUCTOR
        public UcClientBookings(FrmMerendero _parent)
        {
            InitializeComponent();
            Size = new Size(FrmMerendero.UCWIDTH, FrmMerendero.UCHEIGHT);
            Location = new Point(FrmMerendero.X, FrmMerendero.Y);
            parent = _parent;
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Procedure - update listview with own client bookings
        /// </summary>
        public void FillList()
        {
            LvwBookings.Items.Clear();
            parent.Client.ListOwnBookings.Reverse();
            ListViewItem lvi;

            foreach(ClsBooking b in parent.Client.ListOwnBookings)
            {
                string product_name = (ClsAccount.ListProducts.Find(x => x.Id == b.Product)).Name;
                lvi = new ListViewItem(b.Id.ToString());
                lvi.SubItems.Add(product_name);
                lvi.SubItems.Add(b.Timestamp.ToString());
                lvi.SubItems.Add(b.Bar == string.Empty ? "NON CONFERMATO" : "CONFERMATO");
                LvwBookings.Items.Add(lvi);
            }
        }
        #endregion
    }
}

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
    public partial class UcBarBookings : UserControl
    {
        #region FIELDS
        private FrmMerendero parent;
        private string Client;
        #endregion

        #region CONSTRUCTOR
        public UcBarBookings(FrmMerendero _parent)
        {
            InitializeComponent();
            Size = new Size(FrmMerendero.UCWIDTH, FrmMerendero.UCHEIGHT);
            Location = new Point(FrmMerendero.X, FrmMerendero.Y);
            parent = _parent;
            Client = string.Empty;
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Procedure - fill listview with pending bookings
        /// </summary>
        public void FillClientsList()
        {
            LvwBookingClients.Items.Clear();
            LvwSelectedBooking.Items.Clear();

            foreach (string s in parent.Bar.DictBookingsPerClient.Keys)
                LvwBookingClients.Items.Add(new ListViewItem(s));
        }

        /// <summary>
        /// Procedure - update listview with only pending bookings of client selected
        /// </summary>
        private void UpdateSelectedBookings()
        {
            foreach (ListViewItem lvi in LvwSelectedBooking.Items)
                if (lvi.Checked)
                    LvwSelectedBooking.Items.Remove(lvi);
        }

        /// <summary>
        /// Procedure - update listview bookings related to selected client
        /// </summary>
        private void SelectedBooking()
        {
            if (LvwBookingClients.FocusedItem == null) return;

            LvwSelectedBooking.Items.Clear();
            Client = LvwBookingClients.FocusedItem.Text;
            ListViewItem lvi;
            
            foreach (KeyValuePair<string, List<ClsBooking>> pair in parent.Bar.DictOrderedBookings[Client])
            {
                List<ClsBooking> list = pair.Value;
                UcProduct product = ClsAccount.ListMenu.Find(x => x.Name == pair.Key);

                lvi = new ListViewItem(list.Count().ToString());
                lvi.SubItems.Add(pair.Key);
                lvi.SubItems.Add((product.Cost * list.Count()).ToString("c2"));
                lvi.SubItems.Add(product.Category.ToString());
                LvwSelectedBooking.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Procedure - confirm bookings and add to database
        /// </summary>
        private void ConfirmBooking()
        {
            if (LvwBookingClients.FocusedItem == null) return;

            foreach (ListViewItem lvi in LvwSelectedBooking.Items)
                if (lvi.Checked)
                {
                    LvwSelectedBooking.Items.Remove(lvi);
                    parent.Bar.Sell(parent.Bar.DictOrderedBookings[Client][lvi.SubItems[1].Text]);
                }

            FillClientsList();
            UpdateSelectedBookings();
        }

        /// <summary>
        /// Procedure - cancel bookings and delete them from database
        /// </summary>
        private void CancelBooking()
        {
            if (LvwBookingClients.FocusedItem == null) return;

            foreach (ListViewItem lvi in LvwSelectedBooking.Items)
                if (lvi.Checked)
                    parent.Bar.CancelBookings(parent.Bar.DictOrderedBookings[Client][lvi.SubItems[1].Text]);

            FillClientsList();
            UpdateSelectedBookings();
        }
        #endregion

        #region EVENTS
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmBooking();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CancelBooking();
        }

        private void LvwBookingClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedBooking();
        }
        #endregion
    }
}

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
        private FrmMerendero parent;

        public UcClientBookings(FrmMerendero _parent)
        {
            InitializeComponent();
            Size = new Size(FrmMerendero.UCWIDTH, FrmMerendero.UCHEIGHT);
            Location = new Point(FrmMerendero.X, FrmMerendero.Y);
            parent = _parent;
        }

        public void FillList()
        {
            LvwBookings.Items.Clear();
            ListViewItem lvi;

            foreach(ClsBooking b in parent.Client.ListBookings)
            {
                //per booking
            }
        }
    }
}

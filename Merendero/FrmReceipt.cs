using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merendero
{
    public partial class FrmReceipt : Form
    {
        public FrmReceipt(List<ClsBooking> _list)
        {
            InitializeComponent();

            ListViewItem lvi;

            foreach(ClsBooking b in _list)
            {
                lvi = new ListViewItem();
            }
            
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        public FrmReceipt(List<ClsBooking> _list, Dictionary<string, int> _dict)
        {
            InitializeComponent();
            float _fTotalCost = 0f;

            ListViewItem lvi;
            foreach(ClsBooking b in _list)
            {
                UcProduct p = ClsAccount.ListProducts.Find(x => x.Id == b.Product);
                float _fCurrentCost = p.Cost * _dict[p.Name];
                _fTotalCost += _fCurrentCost;
                lvi = new ListViewItem(p.Name);
                lvi.SubItems.Add(_dict[p.Name].ToString());
                lvi.SubItems.Add(_fCurrentCost.ToString("c2"));
                LvwBookings.Items.Add(lvi);
            }

            LblTotalCost.Text = "Prezzo Totale " + _fTotalCost.ToString("c2");
        }

        #region METHODS
        private void Confirm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region EVENTS
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        #endregion
    }
}

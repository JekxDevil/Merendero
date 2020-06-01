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
    public partial class UcAmountProduct : UserControl
    {
        public UcAmountProduct()
        {
            InitializeComponent();
            Width = UcProduct.WIDTH;
            Height = UcProduct.HEIGHT;
        }
    }
}

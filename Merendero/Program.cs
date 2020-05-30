using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Merendero
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection(global::Merendero.Properties.Resources.DatabaseConnectionString);
        public static SqlCommand cmd = new SqlCommand() { Connection = conn };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMerendero());
        }
    }
}

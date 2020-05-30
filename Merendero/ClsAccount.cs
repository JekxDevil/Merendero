using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Merendero
{
    public class ClsAccount
    {
        public enum EnType { ADMIN, BAR, CLIENT }

        public static List<UcProduct> ListProducts { get; private set; } = new List<UcProduct>();
        public static List<UcProduct> ListMenu { get; private set; } = new List<UcProduct>();
        public static Dictionary<string, int> DictAmounts { get; private set; } = new Dictionary<string, int>();

        public string Name { get; private set; }
        public string Password { get; private set; }
        public EnType Type { get; private set; }

        public ClsAccount(string _name, string _password, EnType _type)
        {
            Name = _name;
            Password = _password;
            Type = _type;
        }

        #region METHODS
        /// <summary>
        /// Procedure - updates listproducts, listmenu and dictamounts in once
        /// </summary>
        public static void GetProducts()
        {
            List<UcProduct> list = new List<UcProduct>();
            DictAmounts.Clear();

            try
            {
                Program.conn.Open();
                Program.cmd.CommandText = "SELECT id, name, image, description, cost, category FROM product";
                SqlDataReader reader = Program.cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new UcProduct(
                        (int)reader["id"],
                        (string)reader["name"],
                        (string)reader["image"],
                        (string)reader["description"],
                        Convert.ToSingle(reader["cost"]),
                        (UcProduct.EnCategory)(int)reader["category"]
                        ));

                    //get DictAmount
                    string name = (string)reader["name"];
                    DictAmounts[name] = DictAmounts.ContainsKey(name) ? DictAmounts[name] + 1 : 1;
                }

                reader.Close();
                ListProducts = list;

                //get ListMenu
                ListMenu = ListProducts.GroupBy(x => x.Name).Select(x => x.First()).ToList();
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Errore con la reperibilita' dei prodotti -> " + sqlerror.Message,
                    "Errore reperibilita' prodotti",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            finally
            {
                Program.conn.Close();
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Merendero
{
    public class ClsAccount
    {
        #region ENUM
        public enum EnType { ADMIN, BAR, CLIENT }
        #endregion

        #region FIELDS
        public static List<UcProduct> ListProducts { get; private set; } = new List<UcProduct>();
        public static List<UcProduct> ListMenu { get; private set; } = new List<UcProduct>();
        public static Dictionary<string, int> DictAmounts { get; private set; } = new Dictionary<string, int>();

        public string Name { get; private set; }
        public string Password { get; private set; }
        public EnType Type { get; private set; }
        #endregion

        #region CONSTRUCTORS
        public ClsAccount(string _name, string _password, EnType _type)
        {
            Name = _name;
            Password = _password;
            Type = _type;
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Static Function - search the user account in database
        /// </summary>
        /// <param name="_user">user in string per copy</param>
        /// <param name="_pass">password in string per copy</param>
        /// <returns>type of account logged</returns>
        public static EnType? Login(string _user, string _pass)
        {
            EnType? type = null;

            try
            {
                Program.conn.Open();
                Program.cmd.Parameters.Clear();
                Program.cmd.CommandText = "SELECT type FROM account WHERE name = @user AND password = @pass;";
                Program.cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = _user;
                Program.cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = _pass;
                SqlDataReader reader = Program.cmd.ExecuteReader();
                Program.cmd.Parameters.Clear();

                if (reader.Read())
                    type = (ClsAccount.EnType)reader["type"];

                reader.Close();
            }
            catch (SqlException esql)
            {
                MessageBox.Show("Login fallito: " + esql.Message);
            }
            finally
            {
                Program.conn.Close();
            }

            return type;
        }

        /// <summary>
        /// Static Procedure - updates listproducts, listmenu and dictamounts in once
        /// </summary>
        public static void GetProducts()
        {
            List<UcProduct> list = new List<UcProduct>();
            DictAmounts.Clear();

            try
            {
                Program.conn.Open();
                Program.cmd.Parameters.Clear();
                Program.cmd.CommandText = "SELECT id, name, image, description, cost, category, booked FROM product";
                SqlDataReader reader = Program.cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new UcProduct(
                        (int)reader["id"],
                        (string)reader["name"],
                        (string)reader["image"],
                        (string)reader["description"],
                        Convert.ToSingle(reader["cost"]),
                        (UcProduct.EnCategory)(int)reader["category"],
                        (bool)reader["booked"]
                        ));

                    //get DictAmount for each product registered in menu
                    string name = (string)reader["name"];
                    DictAmounts[name] = DictAmounts.ContainsKey(name) ? DictAmounts[name] + 1 : 1;
                }

                reader.Close();
                ListProducts = list;

                //get ListMenu (single products)
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

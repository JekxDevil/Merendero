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
    public class ClsClient : ClsAccount
    {
        public List<ClsBooking> ListBookings { get; private set; }
        public Dictionary<string, int> DictUnbookableAmounts { get; private set; } = new Dictionary<string, int>();

        #region CONSTRUCTOR
        public ClsClient(string _name, string _password) : base(_name, _password, ClsAccount.EnType.CLIENT)
        {
            ListBookings = new List<ClsBooking>();
            DictUnbookableAmounts = new Dictionary<string, int>();
            ClsAccount.GetProducts();
            this.GetBookings();
        }
        #endregion

        #region METHODS
        public void Book(ClsBooking _booking)
        {
            try
            {
                Program.conn.Open();
                Program.cmd.CommandText = "INSERT INTO booking (client_account, product, timestamp) " +
                    "VALUES (@client_account, @product, @timestamp);";
                Program.cmd.Parameters.Add("@client_account", SqlDbType.VarChar).Value = _booking.Client;
                Program.cmd.Parameters.Add("@product", SqlDbType.VarChar).Value = _booking.Product;
                Program.cmd.Parameters.Add("@timestamp", SqlDbType.VarChar).Value = _booking.Timestamp;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();
                ListBookings.Add(_booking);
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Errore con la creazione della prenotazione -> " + sqlerror.Message,
                    "Errore prenotazione Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            finally
            {
                Program.conn.Close();
            }
        }

        public void GetBookings()
        {
            ListBookings.Clear();
            DictUnbookableAmounts.Clear();

            try
            {
                Program.conn.Open();
                Program.cmd.CommandText = "SELECT id, bar_account, client_account, product, timestamp FROM booking WHERE client_account = @client;";
                Program.cmd.Parameters.Add("@client", SqlDbType.VarChar).Value = this.Name;
                SqlDataReader reader = Program.cmd.ExecuteReader();
                Program.cmd.Parameters.Clear();

                while (reader.Read())
                {
                    string bar = reader["bar_account"] == DBNull.Value ? string.Empty : (string)reader["bar_account"];

                    ListBookings.Add(new ClsBooking(
                        (int)reader["id"],
                        bar,
                        (string)reader["client_account"],
                        (int)reader["product"],
                        (DateTime)reader["timestamp"]
                        ));

                    if (reader["bar_account"] != DBNull.Value)
                    {
                        string product_name = (ClsAccount.ListProducts.Find(x => x.Id == (int)reader["product"])).Name;

                        if (!DictUnbookableAmounts.ContainsKey(product_name))
                            DictUnbookableAmounts[product_name] = 0;

                        DictUnbookableAmounts[product_name]++;
                    }
                }

                reader.Close();
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Errore con la reperibilita' delle prenotazioni -> " + sqlerror.Message,
                    "Errore prenotazioni Database",
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

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

        public ClsClient(string _name, string _password) : base(_name, _password, ClsAccount.EnType.CLIENT)
        {
            ListBookings = new List<ClsBooking>();
            ClsAccount.GetProducts();
        }

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

            try
            {
                Program.conn.Open();
                Program.cmd.CommandText = "SELECT id, bar_account, clien_account, product, timestamp FROM bookings WHERE client_account = @client;";
                Program.cmd.Parameters.Add("@client", SqlDbType.VarChar).Value = this.Name;
                SqlDataReader reader = Program.cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListBookings.Add(new ClsBooking(
                        (int)reader["id"],
                        (string)reader["bar_account"],
                        (string)reader["client_account"],
                        (int)reader["produt"],
                        DateTime.Parse((string)reader["timestamp"])
                        ));
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

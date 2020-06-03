using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Merendero
{
    public class ClsBar : ClsAccount
    {
        #region FIELDS
        //list total pending bookings
        public List<ClsBooking> ListPendingBookings { get; private set; }
        //dictionary of bookings ordered per client
        public Dictionary<string, List<ClsBooking>> DictBookingsPerClient { get; private set; }
        //dictionary of bookings ordered per client, then per product
        public Dictionary<string, Dictionary<string, List<ClsBooking>>> DictOrderedBookings { get; private set; }
        //dictionary of booked products amount
        public Dictionary<string, int> DictSelledAmounts { get; private set; }
        #endregion

        #region CONSTRUCTORS
        public ClsBar(string _name, string _password) : base(_name, _password, ClsAccount.EnType.BAR)
        {
            ListPendingBookings = new List<ClsBooking>();
            DictBookingsPerClient = new Dictionary<string, List<ClsBooking>>();
            DictOrderedBookings = new Dictionary<string, Dictionary<string, List<ClsBooking>>>();
            DictSelledAmounts = new Dictionary<string, int>();
            ClsAccount.GetProducts();
            this.GetBookings();
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Procedure - sell products and update the current database with new bookings
        /// </summary>
        /// <param name="_listbookings">bookings list</param>
        public void Sell(List<ClsBooking> _listbookings)
        {
            try
            {
                //list contains only product which are going to be sold
                Program.conn.Open();
                Program.cmd.Parameters.Clear();
                Program.cmd.CommandText = "UPDATE booking SET bar_account = @bar WHERE id = @id;";
                Program.cmd.Parameters.Add("@bar", SqlDbType.VarChar).Value = this.Name;
                SqlParameter sqlpar_id = Program.cmd.Parameters.Add("@id", SqlDbType.VarChar);

                foreach (ClsBooking b in _listbookings)
                {
                    sqlpar_id.Value = b.Id;
                    Program.cmd.ExecuteNonQuery();
                }

                Program.cmd.Parameters.Clear();
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Problema con l'aggiunta della prenotazione -> " + sqlerror.Message,
                    "Errore prenotazione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            finally
            {
                Program.conn.Close();
                this.GetBookings();
            }
        }

        /// <summary>
        /// Procedure - cancel bookings in database
        /// </summary>
        /// <param name="_listbookings">bookings list</param>
        public void CancelBookings(List<ClsBooking> _listbookings)
        {
            try
            {
                Program.conn.Open();
                Program.cmd.Parameters.Clear();
                Program.cmd.CommandText = "DELETE FROM booking WHERE id = @id;";
                SqlParameter sqlpar_id = Program.cmd.Parameters.Add("@id", SqlDbType.VarChar);

                foreach (ClsBooking b in _listbookings)
                {
                    sqlpar_id.Value = b.Id;
                    Program.cmd.ExecuteNonQuery();
                }

                Program.cmd.Parameters.Clear();
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Problema con l'annullamento della prenotazione -> " + sqlerror.Message,
                    "Errore prenotazione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            finally
            {
                Program.conn.Close();
                this.GetBookings();
            }
        }

        /// <summary>
        /// Procedure - fill pantry with selected product in database
        /// </summary>
        /// <param name="_product">product object</param>
        /// <param name="_amount">amount in int per copy</param>
        public void FillPantry(UcProduct _product, int _amount)
        {
            try
            {
                Program.conn.Open();
                Program.cmd.Parameters.Clear();

                //add products
                for (int i = 0; i < _amount; i++)
                {
                    Program.cmd.CommandText = "INSERT INTO product (name, image, description, cost, category) " +
                        "VALUES (@name, @image, @description, @cost, @category);";
                    Program.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = _product.Name;
                    Program.cmd.Parameters.Add("@image", SqlDbType.VarChar).Value = Path.GetFileNameWithoutExtension((string)_product.Tag);
                    Program.cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = _product.Description;
                    Program.cmd.Parameters.Add("@cost", SqlDbType.Float).Value = _product.Cost;
                    Program.cmd.Parameters.Add("@category", SqlDbType.VarChar).Value = (int)_product.Category;
                    Program.cmd.ExecuteNonQuery();
                    Program.cmd.Parameters.Clear();
                }

                MessageBox.Show("Prodotti aggiunti con successo.");
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Impossibile salvare prodotto o immagine sul Database -> " + sqlerror.Message,
                    "Errore salvataggio su Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            finally
            {
                Program.conn.Close();
                ClsAccount.GetProducts();
            }
        }

        /// <summary>
        /// Procedure - update dictionary of already selled products
        /// </summary>
        public void UpdateDictSelledAmounts()
        {
            DictSelledAmounts.Clear();

            try
            {
                Program.conn.Open();
                Program.cmd.CommandText = "SELECT product FROM booking " +
                    "WHERE bar_account IS NOT NULL;";
                SqlDataReader reader = Program.cmd.ExecuteReader();

                while (reader.Read())
                {
                    int product_id = (int)reader["product"];
                    string product_name = (ClsAccount.ListProducts.Find(x => x.Id == product_id)).Name;

                    if (!DictSelledAmounts.ContainsKey(product_name))
                        DictSelledAmounts[product_name] = 0;

                    DictSelledAmounts[product_name]++;
                }

                reader.Close();
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Errore con la reperibilita' delle prenotazioni gia' confermate -> " + sqlerror.Message,
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

        /// <summary>
        /// Procedure - retrieve bookings from database and put them on list, update dictionaries
        /// </summary>
        private void GetBookings()
        {
            ListPendingBookings.Clear();
            DictBookingsPerClient.Clear();
            DictOrderedBookings.Clear();

            try
            {
                Program.conn.Open();
                Program.cmd.Parameters.Clear();
                Program.cmd.CommandText = "SELECT id, bar_account, client_account, product, timestamp FROM booking " +
                    "WHERE bar_account IS NULL;";
                SqlDataReader reader = Program.cmd.ExecuteReader();

                while (reader.Read())
                {
                    string bar = reader["bar_account"] == DBNull.Value ? string.Empty : (string)reader["bar_account"];

                    ListPendingBookings.Add(new ClsBooking(
                        (int)reader["id"],
                        bar,
                        (string)reader["client_account"],
                        (int)reader["product"],
                        (DateTime)reader["timestamp"]
                        ));

                    //temp variables
                    string client = (string)reader["client_account"];
                    int product_id = (int)reader["product"];
                    string product_name = ClsAccount.ListProducts.Find(x => x.Id == product_id).Name;

                    //get list of bookings ordered by client's name and bookings ordered by products name ordered by client's name
                    //if client isn't registered, insert
                    if (!DictBookingsPerClient.ContainsKey(client))
                    {
                        DictBookingsPerClient[client] = new List<ClsBooking>();
                        DictOrderedBookings[client] = new Dictionary<string, List<ClsBooking>>();
                    }

                    //add his bookings
                    DictBookingsPerClient[client].Add(ListPendingBookings.Last());

                    //if client bookings haven't this product list name registered, create
                    if (!DictOrderedBookings[client].ContainsKey(product_name))
                        DictOrderedBookings[client][product_name] = new List<ClsBooking>();

                    DictOrderedBookings[client][product_name].Add(ListPendingBookings.Last());
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
                UpdateDictSelledAmounts();
            }
        }        
        #endregion
    }
}

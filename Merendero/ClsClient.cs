﻿using System;
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
        #region FIELDS
        public List<ClsBooking> ListOwnBookings { get; private set; }
        public Dictionary<string, int> DictUnbookableAmounts { get; private set; } = new Dictionary<string, int>();
        #endregion

        #region CONSTRUCTOR
        public ClsClient(string _name, string _password) : base(_name, _password, ClsAccount.EnType.CLIENT)
        {
            ListOwnBookings = new List<ClsBooking>();
            DictUnbookableAmounts = new Dictionary<string, int>();
            ClsAccount.GetProducts();
            this.GetBookings();
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Procedure - insert a booking into the database
        /// </summary>
        /// <param name="_booking">booking object</param>
        public void Book(ClsBooking _booking)
        {
            try
            {
                Program.conn.Open();
                Program.cmd.Parameters.Clear();
                Program.cmd.CommandText = "INSERT INTO booking (client_account, product, timestamp) " +
                    "VALUES (@client_account, @product, @timestamp);";
                Program.cmd.Parameters.Add("@client_account", SqlDbType.VarChar).Value = _booking.Client;
                Program.cmd.Parameters.Add("@product", SqlDbType.VarChar).Value = _booking.Product;
                Program.cmd.Parameters.Add("@timestamp", SqlDbType.VarChar).Value = _booking.Timestamp;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();

                Program.cmd.CommandText = "UPDATE product SET booked = 'true' WHERE id = @id;";
                Program.cmd.Parameters.Add("@id", SqlDbType.Int).Value = _booking.Product;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();

                ListOwnBookings.Add(_booking);
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

        /// <summary>
        /// Procedure - get own bookings from database and update dictionary
        /// </summary>
        public void GetBookings()
        {
            ListOwnBookings.Clear();
            DictUnbookableAmounts.Clear();

            try
            {
                Program.conn.Open();
                Program.cmd.Parameters.Clear();
                Program.cmd.CommandText = "SELECT id, bar_account, client_account, product, timestamp FROM booking;";
                SqlDataReader reader = Program.cmd.ExecuteReader();
                Program.cmd.Parameters.Clear();

                while (reader.Read())
                {
                    //if booked insert name of bar account, else keep empty
                    string bar = reader["bar_account"] == DBNull.Value ? string.Empty : (string)reader["bar_account"];
                    string client = (string)reader["client_account"];

                    //if own booking, insert into list
                    if (client == this.Name)
                    {
                        ListOwnBookings.Add(new ClsBooking(
                            (int)reader["id"],
                            bar,
                            (string)reader["client_account"],
                            (int)reader["product"],
                            (DateTime)reader["timestamp"]
                            ));
                    }

                    //keep track about booked products
                    UcProduct p = ClsAccount.ListProducts.Find(x => x.Id == (int)reader["product"]);

                    if (reader["bar_account"] != DBNull.Value || p.Booked)
                    {
                        string product_name = p.Name;

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

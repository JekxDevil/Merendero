﻿using System;
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
        public List<ClsBooking> ListBookings { get; private set; }
        public Dictionary<string, List<ClsBooking>> DictBookingsPerClient { get; private set; }
        public Dictionary<string, Dictionary<string, List<ClsBooking>>> DictOrderedBookings { get; private set; }

        public ClsBar(string _name, string _password) : base(_name, _password, ClsAccount.EnType.BAR)
        {
            ListBookings = new List<ClsBooking>();
            DictBookingsPerClient = new Dictionary<string, List<ClsBooking>>();
            DictOrderedBookings = new Dictionary<string, Dictionary<string, List<ClsBooking>>>();
            ClsAccount.GetProducts();
            this.GetBookings();
        }

        #region METHODS
        public void Sell(List<ClsBooking> _listbookings)
        {
            try
            {
                //list contains only product which are going to be sold
                Program.conn.Open();
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
            }
        }
        
        public void CancelBookings(List<ClsBooking> _listbookings)
        {
            try
            {
                Program.conn.Open();
                Program.cmd.CommandText = "DELETE FROM bookings WHERE id = @id;";
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
            }
        }

        private void GetBookings()
        {
            ListBookings.Clear();
            DictBookingsPerClient.Clear();

            try
            {
                Program.conn.Open();
                Program.cmd.CommandText = "SELECT id, bar_account, client_account, product, timestamp FROM booking " +
                    "WHERE bar_account IS NULL;";
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

                    //temp variables
                    string client = (string)reader["client_account"];
                    int product_id = (int)reader["product"];
                    string product_name = ClsAccount.ListProducts.Find(x => x.Id == product_id).Name;

                    //get list of bookings ordered by client's name and bookings ordered by products name ordered by client's name
                    if (DictBookingsPerClient.ContainsKey(client))
                    {
                        //if client has order registered, then add his bookings
                        DictBookingsPerClient[client].Add(ListBookings.Last());

                        //if client bookings have already this product name registered, then add booking
                        if (DictOrderedBookings[client].ContainsKey(product_name))
                            DictOrderedBookings[client][product_name].Add(ListBookings.Last());
                        else
                            DictOrderedBookings[client][product_name] = new List<ClsBooking>();
                    }
                    else
                    {
                        DictBookingsPerClient[client] = new List<ClsBooking>();
                        DictOrderedBookings[client] = new Dictionary<string, List<ClsBooking>>();
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

        public void FillPantry(UcProduct _product, int _amount)
        {
            try
            {
                Program.conn.Open();

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
        #endregion
    }
}
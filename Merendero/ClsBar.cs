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
        public ClsBar(string _name, string _password) : base(_name, _password, ClsAccount.EnType.BAR) { }

        public bool Sell(List<UcProduct> _listproducts, ClsClient _client)
        {
            //list contains only product which are going to be sold

            try
            {
                Program.conn.Open();

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
            
            //booked successfully 
            return true;
        }

        public void FillPantry(UcProduct _product, int _amount)
        {
            try
            {
                Program.conn.Open();

                //add products
                for (int i = 0; i < _amount; i++)
                {
                    Program.cmd.CommandText = "INSERT INTO product (name, image, description, cost, category)" +
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
    }
}

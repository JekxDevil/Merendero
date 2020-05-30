using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace Merendero
{
    public class ClsAdmin : ClsAccount
    {
        public List<ClsAccount> ListAccounts { get; private set; }

        public ClsAdmin(string _name, string _password) : base(_name, _password, ClsAccount.EnType.ADMIN) { }

        #region METHODS
        public bool AddAccount(ClsAccount _account)
        {
            try
            {
                Program.conn.Open();
                Program.cmd.CommandText = "INSERT INTO account (name, password, type) VALUES (@name, @password, @type);";
                Program.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = _account.Name;
                Program.cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = _account.Password;
                Program.cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = (int)_account.Type;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();

                return true;
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Errore con l'aggiunta dell'account -> " + sqlerror.Message,
                    "Errore aggiunta sul Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                return false;
            }
            finally
            {
                Program.conn.Close();
                GetAccounts();
            }
        }

        public bool EditAccount(ClsAccount _account)
        {
            try
            {
                Program.conn.Open();
                Program.cmd.CommandText = "UPDATE account SET password = @password, type = @type WHERE name = @name;";
                Program.cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = _account.Password;
                Program.cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = (int)_account.Type;
                Program.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = _account.Name;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();

                return true;
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Errore con la modifica dell'account -> " + sqlerror.Message,
                    "Errore modifica sul Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                return false;
            }
            finally
            {
                Program.conn.Close();
                GetAccounts();
            }
        }

        public bool DeleteAccount(ClsAccount _account)
        {
            try
            {
                Program.conn.Open();

                //delete related bookings? may cause problems if lefted


                //delete product
                Program.cmd.CommandText = "DELETE FROM account WHERE name = @name";
                Program.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = _account.Name;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();

                return true;
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Errore con la rimozione dell'account -> " + sqlerror.Message,
                    "Errore rimozione sul Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                return false;
            }
            finally
            {
                Program.conn.Close();
                GetAccounts();
            }
        }

        public void GetAccounts()
        {
            List<ClsAccount> list = new List<ClsAccount>();

            try
            {
                Program.conn.Open();
                Program.cmd.CommandText = "SELECT * FROM account";
                SqlDataReader reader = Program.cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new ClsAccount(
                        (string)reader["name"],
                        (string)reader["password"],
                        (ClsAccount.EnType)(int)reader["type"]
                        ));
                }

                ListAccounts = list;
                reader.Close();
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Errore con la reperibilita' degli account -> " + sqlerror.Message,
                    "Errore reperibilita' account",
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
        /// Function - add the existence of a product
        /// </summary>
        /// <param name="_product">prototype product obj</param>
        /// <returns>true if function works</returns>
        public bool AddProduct(UcProduct _product)
        {
            try
            {
                Program.conn.Open();

                //image first (FK)
                string imagePath = (string)_product.Tag;
                string imageName = Path.GetFileNameWithoutExtension(imagePath);
                FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] imageData = br.ReadBytes((int)fs.Length);

                Program.cmd.CommandText = "INSERT INTO image (name, bindata) VALUES (@name, @bindata);";
                Program.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = imageName;
                Program.cmd.Parameters.Add("@bindata", SqlDbType.Image, imageData.Length).Value = imageData;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();

                br.Close();
                fs.Close();

                //product then
                Program.cmd.CommandText = "INSERT INTO product (name, image, description, cost, category) " +
                    "VALUES (@name, @image, @description, @cost, @category);";
                Program.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = _product.Name;
                Program.cmd.Parameters.Add("@image", SqlDbType.VarChar).Value = imageName;
                Program.cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = _product.Description;
                Program.cmd.Parameters.Add("@cost", SqlDbType.Float).Value = _product.Cost;
                Program.cmd.Parameters.Add("@category", SqlDbType.Int).Value = (int)_product.Category;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();

                return true;
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Impossibile salvare prodotto o immagine sul Database -> " + sqlerror.Message,
                    "Errore salvataggio su Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                return false;
            }
            finally
            {
                Program.conn.Close();
                ClsAccount.GetProducts();
            }
        }

        public bool EditProduct(UcProduct _product)
        {
            try
            {
                Program.conn.Open();

                //edit product
                Program.cmd.CommandText = "UPDATE product SET description = @description, cost = @cost, category = @category " +
                    "WHERE name = @name;";
                Program.cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = _product.Description;
                Program.cmd.Parameters.Add("@cost", SqlDbType.Float).Value = _product.Cost;
                Program.cmd.Parameters.Add("@category", SqlDbType.Int).Value = (int)_product.Category;
                Program.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = _product.Name;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();

                return true;
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Impossibile modificare prodotto sul Database -> " + sqlerror.Message,
                    "Errore salvataggio su Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                return false;
            }
            finally
            {
                Program.conn.Close();
                ClsAccount.GetProducts();
            }
        }

        public bool EditProduct(UcProduct _product, string _oldimage)
        {
            try
            {
                Program.conn.Open();

                //add new image
                string imagePath = (string)_product.Tag;
                string imageName = Path.GetFileNameWithoutExtension(imagePath);
                FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] imageData = br.ReadBytes((int)fs.Length);

                Program.cmd.CommandText = "INSERT INTO image (name, bindata) VALUES (@name, @bindata);";
                Program.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = imageName;
                Program.cmd.Parameters.Add("@bindata", SqlDbType.Image, imageData.Length).Value = imageData;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();

                br.Close();
                fs.Close();

                //edit product
                Program.cmd.CommandText = "UPDATE product SET image = @image, description = @description, cost = @cost, category = @category " +
                    "WHERE name = @name;";
                Program.cmd.Parameters.Add("@image", SqlDbType.VarChar).Value = imageName;
                Program.cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = _product.Description;
                Program.cmd.Parameters.Add("@cost", SqlDbType.Float).Value = _product.Cost;
                Program.cmd.Parameters.Add("@category", SqlDbType.Int).Value = (int)_product.Category;
                Program.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = _product.Name;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();

                //delete always old image, could be different with same name
                Program.cmd.CommandText = "DELETE FROM image WHERE name = @name";
                Program.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = _oldimage;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();

                return true;
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show("Impossibile modificare prodotto o relativa immagine sul Database -> " + sqlerror.Message,
                    "Errore salvataggio su Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                return false;
            }
            finally
            {
                Program.conn.Close();
                ClsAccount.GetProducts();
            }
        }

        /// <summary>
        /// Function - delete a product from existence
        /// </summary>
        /// <param name="_product">product obj as example</param>
        /// <returns>true if function works</returns>
        public bool DeleteProduct(UcProduct _product)
        {
            try
            {
                Program.conn.Open();

                //delete related bookings? may cause problems if lefted


                //delete product
                Program.cmd.CommandText = "DELETE FROM product WHERE name = @name";
                Program.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = _product.Name;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();

                //delete its image
                Program.cmd.CommandText = "DELETE FROM image WHERE name = @name";
                Program.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = _product.Tag;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();

                return true;
            }
            catch(SqlException sqlerror)
            {
                MessageBox.Show("Errore con la rimozione del prodotto o immagine -> " + sqlerror.Message,
                    "Errore rimozione sul Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                return false;
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

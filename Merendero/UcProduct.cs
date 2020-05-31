using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Merendero
{
    public partial class UcProduct : UserControl
    {
        public const int WIDTH = 200;
        public const int HEIGHT = 275;

        public enum EnCategory { BEVANDA, BIBITA, CARAMELLA, DOLCE, PRIMO, SALATO, SECONDO }

        //name inherited
        public int Id { get; private set; }
        public Image Image { get; private set; }
        public string Description { get; private set; }
        public float Cost { get; private set; }
        public EnCategory Category { get; private set; }

        public UcProduct(int _id, string _name, string _image, string _description, float _cost, EnCategory _category)
        {
            InitializeComponent();
            Id = _id;
            Name = _name;
            Image = GetImage(Path.GetFileNameWithoutExtension(_image));
            Tag = _image;     //path if newly added, else name
            Description = _description;
            Cost = _cost;
            Category = _category;

            //design
            Width = WIDTH;
            Height = HEIGHT;
            LblName.Text = this.Name;
            PbxImage.Image = this.Image;
            RtbxDescription.Text = this.Description;
            LblCost.Text = this.Cost.ToString("c2");

            //event handler for client, here cause simplify code
            //used only in showcase view
            Click += UcShowcase.Product_Click;
        }

        public UcProduct(string _name, string _image, string _description, float _cost, EnCategory _category)
        {
            InitializeComponent();
            Name = _name;
            Image = GetImage(Path.GetFileNameWithoutExtension(_image));
            Tag = _image;     //path if newly added, else name
            Description = _description;
            Cost = _cost;
            Category = _category;

            //design
            Width = WIDTH;
            Height = HEIGHT;
            LblName.Text = this.Name;
            PbxImage.Image = this.Image;
            RtbxDescription.Text = this.Description;
            LblCost.Text = this.Cost.ToString("c2");
        }

        private Image GetImage(string _name)
        {
            SqlConnection connection = new SqlConnection(global::Merendero.Properties.Resources.DatabaseConnectionString);
            Image image = null;

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT bindata FROM image WHERE name = @name", connection);
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = _name;
                SqlDataReader reader = command.ExecuteReader();
                command.Parameters.Clear();
                
                if (reader.HasRows && reader.Read())
                {
                    byte[] imageData = (byte[]) reader["bindata"];
                    MemoryStream ms = new MemoryStream(imageData);
                    ms.Seek(0, SeekOrigin.Begin);
                    image = Image.FromStream(ms); 
                }

            }
            catch(SqlException sqlerror)
            {
                MessageBox.Show("Impossibile trovare l'immagine sul Database -> " + sqlerror.Message,
                    "Errore immagine su Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            finally
            {
                connection.Close();
            }

            return image;
        }

        //handler click valuta
    }
}

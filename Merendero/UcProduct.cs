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
        #region CONSTS
        public const int WIDTH = 200;
        public const int HEIGHT = 275;
        #endregion

        #region FIELDS
        public enum EnCategory { BEVANDA, BIBITA, CARAMELLA, DOLCE, PRIMO, SALATO, SECONDO }

        //name inherited
        public int Id { get; private set; }
        public Image Image { get; private set; }
        public string Description { get; private set; }
        public float Cost { get; private set; }
        public EnCategory Category { get; private set; }

        //design management
        public bool Clicked { get; set; }
        public Button BtnOk;
        public NumericUpDown NudAmount;
        private Label LblDescription;
        #endregion

        #region CONSTRUCTORS
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
            this.Clicked = false;
            this.Click += SwitchSide;
            this.LblName.Click += SwitchSide;
            this.PbxImage.Click += SwitchSide;
            this.RtbxDescription.Click += SwitchSide;
            this.LblCost.Click += SwitchSide;

            //design choice side
            this.LblDescription = new Label();
            this.NudAmount = new NumericUpDown();
            this.BtnOk = new Button();

            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new Point(11, 92);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new Size(181, 20);
            this.LblDescription.Text = "Selezionare la quantita\':";

            this.NudAmount.Location = new Point(71, 130);
            this.NudAmount.Maximum = new decimal(new int[] {10, 0, 0, 0});
            this.NudAmount.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.NudAmount.Name = "NudAmount";
            this.NudAmount.Size = new Size(62, 26);
            this.NudAmount.TextAlign = HorizontalAlignment.Right;
            this.NudAmount.Value = new decimal(new int[] {1, 0, 0, 0});

            this.BtnOk.BackColor = Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnOk.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatStyle = FlatStyle.Popup;
            this.BtnOk.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.ForeColor = Color.White;
            this.BtnOk.Location = new Point(33, 227);
            this.BtnOk.Margin = new Padding(0);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new Size(128, 30);
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = false;

            LblDescription.Visible = NudAmount.Visible = BtnOk.Visible = false;

            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.NudAmount);
            this.Controls.Add(this.LblDescription);
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
        #endregion

        #region METHODS
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
        #endregion

        #region EVENTS
        public void SwitchSide(object sender, EventArgs e)
        {
            Clicked = Clicked ? false : true;

            if (Clicked)
            {
                LblDescription.Visible = NudAmount.Visible = BtnOk.Visible = true;
                LblName.Visible = PbxImage.Visible = RtbxDescription.Visible = LblCost.Visible = false;
            }
            else
            {
                LblDescription.Visible = NudAmount.Visible = BtnOk.Visible = false;
                LblName.Visible = PbxImage.Visible = RtbxDescription.Visible = LblCost.Visible = true;
            }
        }
        #endregion
    }
}

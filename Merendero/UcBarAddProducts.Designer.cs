namespace Merendero
{
    partial class UcBarAddProducts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBarAddProducts));
            this.GbxProducts = new System.Windows.Forms.GroupBox();
            this.LvwProducts = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.NudAmount = new System.Windows.Forms.NumericUpDown();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblTitleProduct = new System.Windows.Forms.Label();
            this.LblSelectedProduct = new System.Windows.Forms.Label();
            this.LblAmount = new System.Windows.Forms.Label();
            this.GbxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxProducts
            // 
            this.GbxProducts.Controls.Add(this.LvwProducts);
            this.GbxProducts.Location = new System.Drawing.Point(17, 15);
            this.GbxProducts.Margin = new System.Windows.Forms.Padding(4);
            this.GbxProducts.Name = "GbxProducts";
            this.GbxProducts.Padding = new System.Windows.Forms.Padding(4);
            this.GbxProducts.Size = new System.Drawing.Size(544, 539);
            this.GbxProducts.TabIndex = 0;
            this.GbxProducts.TabStop = false;
            this.GbxProducts.Text = "Lista Prodotti";
            // 
            // LvwProducts
            // 
            this.LvwProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnCost,
            this.columnCategory,
            this.columnAmount});
            this.LvwProducts.FullRowSelect = true;
            this.LvwProducts.HideSelection = false;
            this.LvwProducts.Location = new System.Drawing.Point(7, 26);
            this.LvwProducts.MultiSelect = false;
            this.LvwProducts.Name = "LvwProducts";
            this.LvwProducts.Size = new System.Drawing.Size(530, 506);
            this.LvwProducts.TabIndex = 0;
            this.LvwProducts.UseCompatibleStateImageBehavior = false;
            this.LvwProducts.View = System.Windows.Forms.View.Details;
            this.LvwProducts.SelectedIndexChanged += new System.EventHandler(this.LvwProducts_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Nome";
            this.columnName.Width = 177;
            // 
            // columnCost
            // 
            this.columnCost.Text = "Cost";
            this.columnCost.Width = 92;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Categoria";
            this.columnCategory.Width = 160;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Quantita\'";
            this.columnAmount.Width = 97;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(711, 517);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(193, 30);
            this.BtnConfirm.TabIndex = 7;
            this.BtnConfirm.Text = "AGGIUNGI";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // NudAmount
            // 
            this.NudAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NudAmount.Location = new System.Drawing.Point(711, 340);
            this.NudAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NudAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAmount.Name = "NudAmount";
            this.NudAmount.Size = new System.Drawing.Size(193, 26);
            this.NudAmount.TabIndex = 8;
            this.NudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(587, 41);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(422, 100);
            this.LblDescription.TabIndex = 16;
            this.LblDescription.Text = resources.GetString("LblDescription.Text");
            // 
            // LblTitleProduct
            // 
            this.LblTitleProduct.AutoSize = true;
            this.LblTitleProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleProduct.Location = new System.Drawing.Point(707, 206);
            this.LblTitleProduct.Name = "LblTitleProduct";
            this.LblTitleProduct.Size = new System.Drawing.Size(77, 20);
            this.LblTitleProduct.TabIndex = 17;
            this.LblTitleProduct.Text = "Prodotto:";
            // 
            // LblSelectedProduct
            // 
            this.LblSelectedProduct.AutoSize = true;
            this.LblSelectedProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelectedProduct.Location = new System.Drawing.Point(707, 260);
            this.LblSelectedProduct.Name = "LblSelectedProduct";
            this.LblSelectedProduct.Size = new System.Drawing.Size(84, 20);
            this.LblSelectedProduct.TabIndex = 18;
            this.LblSelectedProduct.Text = "(prodotto)";
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmount.Location = new System.Drawing.Point(707, 314);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(194, 20);
            this.LblAmount.TabIndex = 19;
            this.LblAmount.Text = "Quantita\' da aggiungere:";
            // 
            // UcBarAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.LblSelectedProduct);
            this.Controls.Add(this.LblTitleProduct);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.NudAmount);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.GbxProducts);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcBarAddProducts";
            this.Size = new System.Drawing.Size(1058, 574);
            this.GbxProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxProducts;
        private System.Windows.Forms.ListView LvwProducts;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCost;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.NumericUpDown NudAmount;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblTitleProduct;
        private System.Windows.Forms.Label LblSelectedProduct;
        private System.Windows.Forms.Label LblAmount;
    }
}

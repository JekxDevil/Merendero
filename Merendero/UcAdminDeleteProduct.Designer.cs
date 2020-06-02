namespace Merendero
{
    partial class UcAdminDeleteProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAdminDeleteProduct));
            this.LvwProducts = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnDelete = new System.Windows.Forms.Button();
            this.GbxDeleteProducts = new System.Windows.Forms.GroupBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.GbxDeleteProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvwProducts
            // 
            this.LvwProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnImage,
            this.columnCost,
            this.columnCategory,
            this.columnAmount});
            this.LvwProducts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvwProducts.FullRowSelect = true;
            this.LvwProducts.HideSelection = false;
            this.LvwProducts.Location = new System.Drawing.Point(13, 16);
            this.LvwProducts.MultiSelect = false;
            this.LvwProducts.Name = "LvwProducts";
            this.LvwProducts.Size = new System.Drawing.Size(614, 540);
            this.LvwProducts.TabIndex = 0;
            this.LvwProducts.UseCompatibleStateImageBehavior = false;
            this.LvwProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Nome";
            this.columnName.Width = 146;
            // 
            // columnImage
            // 
            this.columnImage.Text = "Immagine";
            this.columnImage.Width = 123;
            // 
            // columnCost
            // 
            this.columnCost.Text = "Costo";
            this.columnCost.Width = 92;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Categoria";
            this.columnCategory.Width = 154;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Quantita\'";
            this.columnAmount.Width = 94;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(128, 446);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(151, 44);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "ELIMINA";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // GbxDeleteProducts
            // 
            this.GbxDeleteProducts.Controls.Add(this.LblDescription);
            this.GbxDeleteProducts.Controls.Add(this.BtnDelete);
            this.GbxDeleteProducts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxDeleteProducts.Location = new System.Drawing.Point(633, 16);
            this.GbxDeleteProducts.Name = "GbxDeleteProducts";
            this.GbxDeleteProducts.Size = new System.Drawing.Size(412, 540);
            this.GbxDeleteProducts.TabIndex = 5;
            this.GbxDeleteProducts.TabStop = false;
            this.GbxDeleteProducts.Text = "Elimina Prodotti";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(8, 43);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(398, 260);
            this.LblDescription.TabIndex = 5;
            this.LblDescription.Text = resources.GetString("LblDescription.Text");
            // 
            // UcAdminDeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GbxDeleteProducts);
            this.Controls.Add(this.LvwProducts);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcAdminDeleteProduct";
            this.Size = new System.Drawing.Size(1058, 574);
            this.GbxDeleteProducts.ResumeLayout(false);
            this.GbxDeleteProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvwProducts;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.GroupBox GbxDeleteProducts;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCost;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.ColumnHeader columnImage;
        private System.Windows.Forms.ColumnHeader columnAmount;
    }
}

namespace Merendero
{
    partial class UcAdminAddProduct
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
            this.PbxPreviewProduct = new System.Windows.Forms.PictureBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.RtbxDescription = new System.Windows.Forms.RichTextBox();
            this.NudCost = new System.Windows.Forms.NumericUpDown();
            this.CbxCategory = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnFile = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.LblProductDescription = new System.Windows.Forms.Label();
            this.LblCost = new System.Windows.Forms.Label();
            this.LblCategory = new System.Windows.Forms.Label();
            this.GbxProduct = new System.Windows.Forms.GroupBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.LblPath = new System.Windows.Forms.Label();
            this.LblPreview = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LvwProducts = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.PbxPreviewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCost)).BeginInit();
            this.GbxProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbxPreviewProduct
            // 
            this.PbxPreviewProduct.BackColor = System.Drawing.Color.White;
            this.PbxPreviewProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPreviewProduct.Location = new System.Drawing.Point(301, 145);
            this.PbxPreviewProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PbxPreviewProduct.Name = "PbxPreviewProduct";
            this.PbxPreviewProduct.Size = new System.Drawing.Size(200, 200);
            this.PbxPreviewProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxPreviewProduct.TabIndex = 0;
            this.PbxPreviewProduct.TabStop = false;
            // 
            // TbxName
            // 
            this.TbxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TbxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxName.Location = new System.Drawing.Point(19, 65);
            this.TbxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbxName.MaxLength = 20;
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(244, 20);
            this.TbxName.TabIndex = 0;
            // 
            // RtbxDescription
            // 
            this.RtbxDescription.Location = new System.Drawing.Point(19, 123);
            this.RtbxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RtbxDescription.Name = "RtbxDescription";
            this.RtbxDescription.Size = new System.Drawing.Size(244, 145);
            this.RtbxDescription.TabIndex = 1;
            this.RtbxDescription.Text = "";
            // 
            // NudCost
            // 
            this.NudCost.DecimalPlaces = 2;
            this.NudCost.Location = new System.Drawing.Point(19, 319);
            this.NudCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NudCost.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.NudCost.Name = "NudCost";
            this.NudCost.Size = new System.Drawing.Size(244, 26);
            this.NudCost.TabIndex = 2;
            this.NudCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CbxCategory
            // 
            this.CbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategory.FormattingEnabled = true;
            this.CbxCategory.Location = new System.Drawing.Point(19, 395);
            this.CbxCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbxCategory.Name = "CbxCategory";
            this.CbxCategory.Size = new System.Drawing.Size(244, 28);
            this.CbxCategory.TabIndex = 3;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(45, 510);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(181, 30);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "AGGIUNGI";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnFile
            // 
            this.BtnFile.BackColor = System.Drawing.Color.White;
            this.BtnFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnFile.FlatAppearance.BorderSize = 0;
            this.BtnFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFile.ForeColor = System.Drawing.Color.Black;
            this.BtnFile.Location = new System.Drawing.Point(45, 450);
            this.BtnFile.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(181, 27);
            this.BtnFile.TabIndex = 4;
            this.BtnFile.Text = "Seleziona File";
            this.BtnFile.UseVisualStyleBackColor = false;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(14, 35);
            this.LblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(53, 20);
            this.LblName.TabIndex = 10;
            this.LblName.Text = "Nome";
            // 
            // LblProductDescription
            // 
            this.LblProductDescription.AutoSize = true;
            this.LblProductDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductDescription.Location = new System.Drawing.Point(13, 98);
            this.LblProductDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProductDescription.Name = "LblProductDescription";
            this.LblProductDescription.Size = new System.Drawing.Size(92, 20);
            this.LblProductDescription.TabIndex = 11;
            this.LblProductDescription.Text = "Descrizione";
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCost.Location = new System.Drawing.Point(12, 289);
            this.LblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(52, 20);
            this.LblCost.TabIndex = 12;
            this.LblCost.Text = "Costo";
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategory.Location = new System.Drawing.Point(11, 365);
            this.LblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(84, 20);
            this.LblCategory.TabIndex = 13;
            this.LblCategory.Text = "Categoria";
            // 
            // GbxProduct
            // 
            this.GbxProduct.Controls.Add(this.BtnEdit);
            this.GbxProduct.Controls.Add(this.LblPath);
            this.GbxProduct.Controls.Add(this.LblPreview);
            this.GbxProduct.Controls.Add(this.BtnFile);
            this.GbxProduct.Controls.Add(this.CbxCategory);
            this.GbxProduct.Controls.Add(this.PbxPreviewProduct);
            this.GbxProduct.Controls.Add(this.BtnAdd);
            this.GbxProduct.Controls.Add(this.LblProductDescription);
            this.GbxProduct.Controls.Add(this.NudCost);
            this.GbxProduct.Controls.Add(this.LblCategory);
            this.GbxProduct.Controls.Add(this.RtbxDescription);
            this.GbxProduct.Controls.Add(this.LblName);
            this.GbxProduct.Controls.Add(this.TbxName);
            this.GbxProduct.Controls.Add(this.LblCost);
            this.GbxProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxProduct.Location = new System.Drawing.Point(18, 15);
            this.GbxProduct.Margin = new System.Windows.Forms.Padding(4);
            this.GbxProduct.Name = "GbxProduct";
            this.GbxProduct.Padding = new System.Windows.Forms.Padding(4);
            this.GbxProduct.Size = new System.Drawing.Size(508, 555);
            this.GbxProduct.TabIndex = 14;
            this.GbxProduct.TabStop = false;
            this.GbxProduct.Text = "Aggiungi Prodotto";
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(277, 510);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(181, 30);
            this.BtnEdit.TabIndex = 15;
            this.BtnEdit.Text = "MODIFICA";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPath.Location = new System.Drawing.Point(232, 461);
            this.LblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(35, 16);
            this.LblPath.TabIndex = 14;
            this.LblPath.Text = "path";
            // 
            // LblPreview
            // 
            this.LblPreview.AutoSize = true;
            this.LblPreview.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreview.Location = new System.Drawing.Point(297, 120);
            this.LblPreview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPreview.Name = "LblPreview";
            this.LblPreview.Size = new System.Drawing.Size(121, 20);
            this.LblPreview.TabIndex = 14;
            this.LblPreview.Text = "Anteprima Foto";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(543, 15);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(477, 100);
            this.LblDescription.TabIndex = 15;
            this.LblDescription.Text = "Dalla seguente schermata l\'admin puo\' aggiungere un prodotto,\r\nincludendolo alla " +
    "lista del catalogo dei prodotti disponibili e\r\nofferti dal bar.\r\n\r\nATTENZIONE: I" +
    "l nome del prodotto non e\' modificabile";
            // 
            // LvwProducts
            // 
            this.LvwProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnDescription,
            this.columnCost,
            this.columnCategory});
            this.LvwProducts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvwProducts.FullRowSelect = true;
            this.LvwProducts.HideSelection = false;
            this.LvwProducts.Location = new System.Drawing.Point(547, 123);
            this.LvwProducts.Margin = new System.Windows.Forms.Padding(4);
            this.LvwProducts.MultiSelect = false;
            this.LvwProducts.Name = "LvwProducts";
            this.LvwProducts.Size = new System.Drawing.Size(493, 447);
            this.LvwProducts.TabIndex = 16;
            this.LvwProducts.UseCompatibleStateImageBehavior = false;
            this.LvwProducts.View = System.Windows.Forms.View.Details;
            this.LvwProducts.SelectedIndexChanged += new System.EventHandler(this.LvwProducts_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Nome";
            this.columnName.Width = 134;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Descrizione";
            this.columnDescription.Width = 171;
            // 
            // columnCost
            // 
            this.columnCost.Text = "Costo";
            this.columnCost.Width = 71;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Categoria";
            this.columnCategory.Width = 113;
            // 
            // UcAdminAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LvwProducts);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.GbxProduct);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcAdminAddProduct";
            this.Size = new System.Drawing.Size(1058, 574);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPreviewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCost)).EndInit();
            this.GbxProduct.ResumeLayout(false);
            this.GbxProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxPreviewProduct;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.RichTextBox RtbxDescription;
        private System.Windows.Forms.NumericUpDown NudCost;
        private System.Windows.Forms.ComboBox CbxCategory;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblProductDescription;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.GroupBox GbxProduct;
        private System.Windows.Forms.Label LblPreview;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.ListView LvwProducts;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnCost;
        private System.Windows.Forms.ColumnHeader columnCategory;
    }
}

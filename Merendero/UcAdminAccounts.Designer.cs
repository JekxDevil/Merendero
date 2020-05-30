namespace Merendero
{
    partial class UcAdminAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAdminAccounts));
            this.LvwAccounts = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GbxAccount = new System.Windows.Forms.GroupBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.CbxType = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.GbxAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvwAccounts
            // 
            this.LvwAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPassword,
            this.columnType});
            this.LvwAccounts.FullRowSelect = true;
            this.LvwAccounts.HideSelection = false;
            this.LvwAccounts.Location = new System.Drawing.Point(552, 21);
            this.LvwAccounts.MultiSelect = false;
            this.LvwAccounts.Name = "LvwAccounts";
            this.LvwAccounts.Size = new System.Drawing.Size(491, 539);
            this.LvwAccounts.TabIndex = 0;
            this.LvwAccounts.UseCompatibleStateImageBehavior = false;
            this.LvwAccounts.View = System.Windows.Forms.View.Details;
            this.LvwAccounts.SelectedIndexChanged += new System.EventHandler(this.LvwAccounts_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Nome";
            this.columnName.Width = 184;
            // 
            // columnPassword
            // 
            this.columnPassword.Text = "Password";
            this.columnPassword.Width = 194;
            // 
            // columnType
            // 
            this.columnType.Text = "Tipologia";
            this.columnType.Width = 107;
            // 
            // GbxAccount
            // 
            this.GbxAccount.Controls.Add(this.LblDescription);
            this.GbxAccount.Controls.Add(this.BtnDelete);
            this.GbxAccount.Controls.Add(this.BtnEdit);
            this.GbxAccount.Controls.Add(this.TbxPassword);
            this.GbxAccount.Controls.Add(this.CbxType);
            this.GbxAccount.Controls.Add(this.BtnAdd);
            this.GbxAccount.Controls.Add(this.LblPassword);
            this.GbxAccount.Controls.Add(this.LblType);
            this.GbxAccount.Controls.Add(this.LblName);
            this.GbxAccount.Controls.Add(this.TbxName);
            this.GbxAccount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxAccount.Location = new System.Drawing.Point(13, 12);
            this.GbxAccount.Name = "GbxAccount";
            this.GbxAccount.Size = new System.Drawing.Size(533, 548);
            this.GbxAccount.TabIndex = 15;
            this.GbxAccount.TabStop = false;
            this.GbxAccount.Text = "Gestione Account";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(41, 22);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(483, 80);
            this.LblDescription.TabIndex = 18;
            this.LblDescription.Text = resources.GetString("LblDescription.Text");
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(130, 496);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(290, 30);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "ELIMINA";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(130, 431);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(290, 30);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "MODIFICA";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // TbxPassword
            // 
            this.TbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPassword.Location = new System.Drawing.Point(45, 212);
            this.TbxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxPassword.MaxLength = 20;
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(325, 20);
            this.TbxPassword.TabIndex = 1;
            // 
            // CbxType
            // 
            this.CbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxType.FormattingEnabled = true;
            this.CbxType.Location = new System.Drawing.Point(46, 286);
            this.CbxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxType.Name = "CbxType";
            this.CbxType.Size = new System.Drawing.Size(193, 28);
            this.CbxType.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(130, 366);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(290, 30);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "AGGIUNGI";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(42, 186);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(79, 20);
            this.LblPassword.TabIndex = 11;
            this.LblPassword.Text = "Password";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(42, 262);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(73, 20);
            this.LblType.TabIndex = 13;
            this.LblType.Text = "Tipologia";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(42, 114);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(53, 20);
            this.LblName.TabIndex = 10;
            this.LblName.Text = "Nome";
            // 
            // TbxName
            // 
            this.TbxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TbxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxName.Location = new System.Drawing.Point(46, 138);
            this.TbxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbxName.MaxLength = 20;
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(325, 20);
            this.TbxName.TabIndex = 0;
            // 
            // UcAdminAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GbxAccount);
            this.Controls.Add(this.LvwAccounts);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcAdminAccounts";
            this.Size = new System.Drawing.Size(1058, 574);
            this.GbxAccount.ResumeLayout(false);
            this.GbxAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvwAccounts;
        private System.Windows.Forms.GroupBox GbxAccount;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.ComboBox CbxType;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPassword;
        private System.Windows.Forms.ColumnHeader columnType;
    }
}

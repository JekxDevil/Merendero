namespace Merendero
{
    partial class FrmReceipt
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LvwBookings = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GbxReceipt = new System.Windows.Forms.GroupBox();
            this.LblTotalCost = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GbxReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvwBookings
            // 
            this.LvwBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnAmount,
            this.columnCost});
            this.LvwBookings.FullRowSelect = true;
            this.LvwBookings.HideSelection = false;
            this.LvwBookings.Location = new System.Drawing.Point(18, 25);
            this.LvwBookings.MultiSelect = false;
            this.LvwBookings.Name = "LvwBookings";
            this.LvwBookings.Size = new System.Drawing.Size(391, 520);
            this.LvwBookings.TabIndex = 0;
            this.LvwBookings.UseCompatibleStateImageBehavior = false;
            this.LvwBookings.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Nome";
            this.columnName.Width = 142;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Quantità";
            this.columnAmount.Width = 128;
            // 
            // columnCost
            // 
            this.columnCost.Text = "Prezzo";
            this.columnCost.Width = 116;
            // 
            // GbxReceipt
            // 
            this.GbxReceipt.Controls.Add(this.LvwBookings);
            this.GbxReceipt.Location = new System.Drawing.Point(12, 12);
            this.GbxReceipt.Name = "GbxReceipt";
            this.GbxReceipt.Size = new System.Drawing.Size(423, 566);
            this.GbxReceipt.TabIndex = 1;
            this.GbxReceipt.TabStop = false;
            this.GbxReceipt.Text = "Scontrino";
            // 
            // LblTotalCost
            // 
            this.LblTotalCost.AutoSize = true;
            this.LblTotalCost.Location = new System.Drawing.Point(260, 581);
            this.LblTotalCost.Name = "LblTotalCost";
            this.LblTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTotalCost.Size = new System.Drawing.Size(161, 20);
            this.LblTotalCost.TabIndex = 2;
            this.LblTotalCost.Text = "prezzo totale: 10,00 e";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.Green;
            this.BtnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(288, 638);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(128, 30);
            this.BtnConfirm.TabIndex = 22;
            this.BtnConfirm.Text = "CONFERMA";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(30, 638);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(128, 30);
            this.BtnCancel.TabIndex = 23;
            this.BtnCancel.Text = "ANNULLA";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 686);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.LblTotalCost);
            this.Controls.Add(this.GbxReceipt);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmReceipt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReceipt";
            this.GbxReceipt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LvwBookings;
        private System.Windows.Forms.GroupBox GbxReceipt;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.ColumnHeader columnCost;
        private System.Windows.Forms.Label LblTotalCost;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
    }
}
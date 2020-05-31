namespace Merendero
{
    partial class UcBarBookings
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
            this.LvwBookingClients = new System.Windows.Forms.ListView();
            this.GbxBookingClients = new System.Windows.Forms.GroupBox();
            this.GbxBooking = new System.Windows.Forms.GroupBox();
            this.LvwSelectedBooking = new System.Windows.Forms.ListView();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.LblDescription = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.columnClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GbxBookingClients.SuspendLayout();
            this.GbxBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvwBookingClients
            // 
            this.LvwBookingClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnClient});
            this.LvwBookingClients.FullRowSelect = true;
            this.LvwBookingClients.HideSelection = false;
            this.LvwBookingClients.Location = new System.Drawing.Point(300, 58);
            this.LvwBookingClients.MultiSelect = false;
            this.LvwBookingClients.Name = "LvwBookingClients";
            this.LvwBookingClients.Size = new System.Drawing.Size(258, 445);
            this.LvwBookingClients.TabIndex = 0;
            this.LvwBookingClients.UseCompatibleStateImageBehavior = false;
            this.LvwBookingClients.View = System.Windows.Forms.View.Details;
            this.LvwBookingClients.SelectedIndexChanged += new System.EventHandler(this.LvwBookingClients_SelectedIndexChanged);
            // 
            // GbxBookingClients
            // 
            this.GbxBookingClients.Controls.Add(this.LblDescription);
            this.GbxBookingClients.Controls.Add(this.LvwBookingClients);
            this.GbxBookingClients.Location = new System.Drawing.Point(3, 3);
            this.GbxBookingClients.Name = "GbxBookingClients";
            this.GbxBookingClients.Size = new System.Drawing.Size(564, 568);
            this.GbxBookingClients.TabIndex = 1;
            this.GbxBookingClients.TabStop = false;
            this.GbxBookingClients.Text = "Prenotazioni Attive";
            // 
            // GbxBooking
            // 
            this.GbxBooking.Controls.Add(this.BtnCancel);
            this.GbxBooking.Controls.Add(this.BtnConfirm);
            this.GbxBooking.Controls.Add(this.LvwSelectedBooking);
            this.GbxBooking.Location = new System.Drawing.Point(573, 6);
            this.GbxBooking.Name = "GbxBooking";
            this.GbxBooking.Size = new System.Drawing.Size(482, 565);
            this.GbxBooking.TabIndex = 2;
            this.GbxBooking.TabStop = false;
            this.GbxBooking.Text = "Prenotazione Selezionata";
            // 
            // LvwSelectedBooking
            // 
            this.LvwSelectedBooking.CheckBoxes = true;
            this.LvwSelectedBooking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAmount,
            this.columnName,
            this.columnTotalCost,
            this.columnCategory});
            this.LvwSelectedBooking.FullRowSelect = true;
            this.LvwSelectedBooking.HideSelection = false;
            this.LvwSelectedBooking.Location = new System.Drawing.Point(32, 55);
            this.LvwSelectedBooking.MultiSelect = false;
            this.LvwSelectedBooking.Name = "LvwSelectedBooking";
            this.LvwSelectedBooking.Size = new System.Drawing.Size(419, 445);
            this.LvwSelectedBooking.TabIndex = 1;
            this.LvwSelectedBooking.UseCompatibleStateImageBehavior = false;
            this.LvwSelectedBooking.View = System.Windows.Forms.View.Details;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(32, 514);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(181, 30);
            this.BtnConfirm.TabIndex = 16;
            this.BtnConfirm.Text = "CONFERMA";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(7, 188);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(286, 100);
            this.LblDescription.TabIndex = 16;
            this.LblDescription.Text = "Dalla seguente schermata il barista\r\npuo\' confermare o eliminare le\r\nprenotazioni" +
    " fatte dai clienti con\r\nl\'applicazione, scegliendo anche\r\nnel dettaglio quali pr" +
    "odotti assegnare.";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(270, 514);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(181, 30);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "CANCELLA";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // columnClient
            // 
            this.columnClient.Text = "Nome Cliente";
            this.columnClient.Width = 252;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Quantita\'";
            this.columnAmount.Width = 81;
            // 
            // columnName
            // 
            this.columnName.Text = "Nome";
            this.columnName.Width = 129;
            // 
            // columnTotalCost
            // 
            this.columnTotalCost.Text = "Costo Totale";
            this.columnTotalCost.Width = 104;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Categoria";
            this.columnCategory.Width = 101;
            // 
            // UcBarBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GbxBooking);
            this.Controls.Add(this.GbxBookingClients);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcBarBookings";
            this.Size = new System.Drawing.Size(1058, 574);
            this.GbxBookingClients.ResumeLayout(false);
            this.GbxBookingClients.PerformLayout();
            this.GbxBooking.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvwBookingClients;
        private System.Windows.Forms.GroupBox GbxBookingClients;
        private System.Windows.Forms.GroupBox GbxBooking;
        private System.Windows.Forms.ListView LvwSelectedBooking;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ColumnHeader columnClient;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnTotalCost;
        private System.Windows.Forms.ColumnHeader columnCategory;
    }
}

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
            this.GbxBookingClients.SuspendLayout();
            this.GbxBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvwBookingClients
            // 
            this.LvwBookingClients.FullRowSelect = true;
            this.LvwBookingClients.HideSelection = false;
            this.LvwBookingClients.Location = new System.Drawing.Point(6, 145);
            this.LvwBookingClients.MultiSelect = false;
            this.LvwBookingClients.Name = "LvwBookingClients";
            this.LvwBookingClients.Size = new System.Drawing.Size(576, 417);
            this.LvwBookingClients.TabIndex = 0;
            this.LvwBookingClients.UseCompatibleStateImageBehavior = false;
            this.LvwBookingClients.View = System.Windows.Forms.View.Details;
            // 
            // GbxBookingClients
            // 
            this.GbxBookingClients.Controls.Add(this.LblDescription);
            this.GbxBookingClients.Controls.Add(this.LvwBookingClients);
            this.GbxBookingClients.Location = new System.Drawing.Point(3, 3);
            this.GbxBookingClients.Name = "GbxBookingClients";
            this.GbxBookingClients.Size = new System.Drawing.Size(588, 568);
            this.GbxBookingClients.TabIndex = 1;
            this.GbxBookingClients.TabStop = false;
            this.GbxBookingClients.Text = "Prenotazioni Attive";
            // 
            // GbxBooking
            // 
            this.GbxBooking.Controls.Add(this.BtnConfirm);
            this.GbxBooking.Controls.Add(this.LvwSelectedBooking);
            this.GbxBooking.Location = new System.Drawing.Point(597, 6);
            this.GbxBooking.Name = "GbxBooking";
            this.GbxBooking.Size = new System.Drawing.Size(458, 565);
            this.GbxBooking.TabIndex = 2;
            this.GbxBooking.TabStop = false;
            this.GbxBooking.Text = "Prenotazione Selezionata";
            // 
            // LvwSelectedBooking
            // 
            this.LvwSelectedBooking.CheckBoxes = true;
            this.LvwSelectedBooking.FullRowSelect = true;
            this.LvwSelectedBooking.HideSelection = false;
            this.LvwSelectedBooking.Location = new System.Drawing.Point(8, 33);
            this.LvwSelectedBooking.MultiSelect = false;
            this.LvwSelectedBooking.Name = "LvwSelectedBooking";
            this.LvwSelectedBooking.Size = new System.Drawing.Size(444, 445);
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
            this.BtnConfirm.Location = new System.Drawing.Point(140, 517);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(181, 30);
            this.BtnConfirm.TabIndex = 16;
            this.BtnConfirm.Text = "CONFERMA";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(7, 36);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(492, 60);
            this.LblDescription.TabIndex = 16;
            this.LblDescription.Text = "Dalla seguente schermata il barista puo\' confermare o eliminare le\r\nprenotazioni " +
    "fatte dai clienti con l\'applicazione, scegliendo anche\r\nnel dettaglio quali prod" +
    "otti assegnare";
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
    }
}

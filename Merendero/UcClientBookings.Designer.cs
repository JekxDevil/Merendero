namespace Merendero
{
    partial class UcClientBookings
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
            this.LblDescription = new System.Windows.Forms.Label();
            this.LvwBookings = new System.Windows.Forms.ListView();
            this.columnProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(13, 11);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(927, 40);
            this.LblDescription.TabIndex = 20;
            this.LblDescription.Text = "Benvenuto sulle tue Prenotazioni!\r\nQui puoi vedere le tue prenotazioni effettuate" +
    " e il loro stato. Il bar ti inviera\' un feedback se la prenotazione e\' pronta o " +
    "meno.";
            // 
            // LvwBookings
            // 
            this.LvwBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProductName,
            this.columnAmount,
            this.columnTimestamp,
            this.columnState});
            this.LvwBookings.FullRowSelect = true;
            this.LvwBookings.HideSelection = false;
            this.LvwBookings.Location = new System.Drawing.Point(17, 73);
            this.LvwBookings.MultiSelect = false;
            this.LvwBookings.Name = "LvwBookings";
            this.LvwBookings.Size = new System.Drawing.Size(1022, 480);
            this.LvwBookings.TabIndex = 21;
            this.LvwBookings.UseCompatibleStateImageBehavior = false;
            this.LvwBookings.View = System.Windows.Forms.View.Details;
            // 
            // columnProductName
            // 
            this.columnProductName.Text = "Nome Prodotto";
            this.columnProductName.Width = 405;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Quantita\'";
            this.columnAmount.Width = 176;
            // 
            // columnTimestamp
            // 
            this.columnTimestamp.Text = "Data";
            this.columnTimestamp.Width = 241;
            // 
            // columnState
            // 
            this.columnState.Text = "Stato";
            this.columnState.Width = 185;
            // 
            // UcClientBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LvwBookings);
            this.Controls.Add(this.LblDescription);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcClientBookings";
            this.Size = new System.Drawing.Size(1058, 574);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.ListView LvwBookings;
        private System.Windows.Forms.ColumnHeader columnProductName;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.ColumnHeader columnTimestamp;
        private System.Windows.Forms.ColumnHeader columnState;
    }
}

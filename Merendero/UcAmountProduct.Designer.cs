namespace Merendero
{
    partial class UcAmountProduct
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
            this.NudAmount = new System.Windows.Forms.NumericUpDown();
            this.BtnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(11, 92);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(181, 20);
            this.LblDescription.TabIndex = 0;
            this.LblDescription.Text = "Selezionare la quantita\':";
            // 
            // NudAmount
            // 
            this.NudAmount.Location = new System.Drawing.Point(71, 130);
            this.NudAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAmount.Name = "NudAmount";
            this.NudAmount.Size = new System.Drawing.Size(62, 26);
            this.NudAmount.TabIndex = 1;
            this.NudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Location = new System.Drawing.Point(33, 227);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(128, 30);
            this.BtnOk.TabIndex = 21;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = false;
            // 
            // UcAmountProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.NudAmount);
            this.Controls.Add(this.LblDescription);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcAmountProduct";
            this.Size = new System.Drawing.Size(200, 275);
            ((System.ComponentModel.ISupportInitialize)(this.NudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Button BtnOk;
        public System.Windows.Forms.NumericUpDown NudAmount;
    }
}

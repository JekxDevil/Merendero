namespace Merendero
{
    partial class UcProduct
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblCost = new System.Windows.Forms.Label();
            this.PbxImage = new System.Windows.Forms.PictureBox();
            this.RtbxDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(3, 10);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(67, 19);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "(nome)";
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.LblCost.Location = new System.Drawing.Point(112, 251);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(85, 23);
            this.LblCost.TabIndex = 6;
            this.LblCost.Text = "(prezzo)";
            // 
            // PbxImage
            // 
            this.PbxImage.BackColor = System.Drawing.Color.Transparent;
            this.PbxImage.Location = new System.Drawing.Point(7, 32);
            this.PbxImage.Name = "PbxImage";
            this.PbxImage.Size = new System.Drawing.Size(185, 177);
            this.PbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxImage.TabIndex = 7;
            this.PbxImage.TabStop = false;
            // 
            // RtbxDescription
            // 
            this.RtbxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.RtbxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbxDescription.Location = new System.Drawing.Point(7, 215);
            this.RtbxDescription.Name = "RtbxDescription";
            this.RtbxDescription.ReadOnly = true;
            this.RtbxDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RtbxDescription.Size = new System.Drawing.Size(185, 33);
            this.RtbxDescription.TabIndex = 8;
            this.RtbxDescription.Text = "(descrizione)";
            // 
            // UcProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.RtbxDescription);
            this.Controls.Add(this.PbxImage);
            this.Controls.Add(this.LblCost);
            this.Controls.Add(this.LblName);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcProduct";
            this.Size = new System.Drawing.Size(200, 275);
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.PictureBox PbxImage;
        private System.Windows.Forms.RichTextBox RtbxDescription;
    }
}

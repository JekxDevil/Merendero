namespace Merendero
{
    partial class UcShowcase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcShowcase));
            this.FlpnlProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.LblDescription = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlpnlProducts
            // 
            this.FlpnlProducts.AutoScroll = true;
            this.FlpnlProducts.Location = new System.Drawing.Point(3, 98);
            this.FlpnlProducts.Name = "FlpnlProducts";
            this.FlpnlProducts.Size = new System.Drawing.Size(1052, 473);
            this.FlpnlProducts.TabIndex = 0;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(12, 15);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(684, 60);
            this.LblDescription.TabIndex = 19;
            this.LblDescription.Text = resources.GetString("LblDescription.Text");
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(807, 45);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(193, 30);
            this.BtnConfirm.TabIndex = 20;
            this.BtnConfirm.Text = "CONFERMA";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // UcShowcase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.FlpnlProducts);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcShowcase";
            this.Size = new System.Drawing.Size(1058, 574);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpnlProducts;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Button BtnConfirm;
    }
}

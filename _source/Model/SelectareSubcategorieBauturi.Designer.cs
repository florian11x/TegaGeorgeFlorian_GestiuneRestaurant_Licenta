namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta
{
    partial class frmSelectareSubcategorieBauturi
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
            this.panouSubcategorii = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.buttonToatebauturile = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // panouSubcategorii
            // 
            this.panouSubcategorii.Location = new System.Drawing.Point(12, 47);
            this.panouSubcategorii.Name = "panouSubcategorii";
            this.panouSubcategorii.Size = new System.Drawing.Size(776, 188);
            this.panouSubcategorii.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(558, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // buttonToatebauturile
            // 
            this.buttonToatebauturile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToatebauturile.AutoRoundedCorners = true;
            this.buttonToatebauturile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonToatebauturile.BorderRadius = 29;
            this.buttonToatebauturile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonToatebauturile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonToatebauturile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonToatebauturile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonToatebauturile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonToatebauturile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToatebauturile.ForeColor = System.Drawing.Color.White;
            this.buttonToatebauturile.Location = new System.Drawing.Point(184, 354);
            this.buttonToatebauturile.Name = "buttonToatebauturile";
            this.buttonToatebauturile.Size = new System.Drawing.Size(239, 60);
            this.buttonToatebauturile.TabIndex = 17;
            this.buttonToatebauturile.Text = "Toate bauturile";
            this.buttonToatebauturile.Click += new System.EventHandler(this.buttonToatebauturile_Click);
            // 
            // frmSelectareSubcategorieBauturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.buttonToatebauturile);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.panouSubcategorii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelectareSubcategorieBauturi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectareSubcategorieBauturi";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panouSubcategorii;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public Guna.UI2.WinForms.Guna2Button buttonToatebauturile;
    }
}
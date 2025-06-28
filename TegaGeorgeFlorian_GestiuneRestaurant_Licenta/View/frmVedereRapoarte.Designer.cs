namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.View
{
    partial class frmVedereRapoarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVedereRapoarte));
            this.buttonVanzari = new Guna.UI2.WinForms.Guna2Button();
            this.buttonPersonal = new Guna.UI2.WinForms.Guna2Button();
            this.buttonMeniu = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // buttonVanzari
            // 
            this.buttonVanzari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonVanzari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonVanzari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonVanzari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonVanzari.FillColor = System.Drawing.Color.DarkGray;
            this.buttonVanzari.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVanzari.ForeColor = System.Drawing.Color.White;
            this.buttonVanzari.Image = ((System.Drawing.Image)(resources.GetObject("buttonVanzari.Image")));
            this.buttonVanzari.Location = new System.Drawing.Point(461, 94);
            this.buttonVanzari.Name = "buttonVanzari";
            this.buttonVanzari.Size = new System.Drawing.Size(200, 180);
            this.buttonVanzari.TabIndex = 3;
            this.buttonVanzari.Text = "Raport vânzari ";
            this.buttonVanzari.Click += new System.EventHandler(this.buttonVanzari_Click);
            // 
            // buttonPersonal
            // 
            this.buttonPersonal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPersonal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPersonal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPersonal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPersonal.FillColor = System.Drawing.Color.DarkGray;
            this.buttonPersonal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonal.ForeColor = System.Drawing.Color.White;
            this.buttonPersonal.Image = global::TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Properties.Resources.staff;
            this.buttonPersonal.Location = new System.Drawing.Point(255, 94);
            this.buttonPersonal.Name = "buttonPersonal";
            this.buttonPersonal.Size = new System.Drawing.Size(200, 180);
            this.buttonPersonal.TabIndex = 2;
            this.buttonPersonal.Text = "Raport personal";
            this.buttonPersonal.Click += new System.EventHandler(this.buttonPersonal_Click);
            // 
            // buttonMeniu
            // 
            this.buttonMeniu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMeniu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMeniu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMeniu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMeniu.FillColor = System.Drawing.Color.DarkGray;
            this.buttonMeniu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeniu.ForeColor = System.Drawing.Color.White;
            this.buttonMeniu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMeniu.Image")));
            this.buttonMeniu.Location = new System.Drawing.Point(49, 94);
            this.buttonMeniu.Name = "buttonMeniu";
            this.buttonMeniu.Size = new System.Drawing.Size(200, 180);
            this.buttonMeniu.TabIndex = 1;
            this.buttonMeniu.Text = "Raport meniu";
            this.buttonMeniu.Click += new System.EventHandler(this.buttonMeniu_Click);
            // 
            // frmVedereRapoarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 567);
            this.Controls.Add(this.buttonVanzari);
            this.Controls.Add(this.buttonPersonal);
            this.Controls.Add(this.buttonMeniu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVedereRapoarte";
            this.Text = "frmVedereRapoarte";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button buttonMeniu;
        private Guna.UI2.WinForms.Guna2Button buttonPersonal;
        private Guna.UI2.WinForms.Guna2Button buttonVanzari;
    }
}
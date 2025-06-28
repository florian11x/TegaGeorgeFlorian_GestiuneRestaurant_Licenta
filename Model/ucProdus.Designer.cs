namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Model
{
    partial class ucProdus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProdus));
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.labelNume = new System.Windows.Forms.Label();
            this.textImagine = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textImagine)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.panel1);
            this.guna2ShadowPanel1.Controls.Add(this.textImagine);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(185, 185);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Separator1);
            this.panel1.Controls.Add(this.labelNume);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 51);
            this.panel1.TabIndex = 1;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, -6);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(206, 13);
            this.guna2Separator1.TabIndex = 1;
            // 
            // labelNume
            // 
            this.labelNume.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.Location = new System.Drawing.Point(17, 1);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(153, 38);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume Produs";
            this.labelNume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textImagine
            // 
            this.textImagine.Image = ((System.Drawing.Image)(resources.GetObject("textImagine.Image")));
            this.textImagine.ImageRotate = 0F;
            this.textImagine.Location = new System.Drawing.Point(18, 10);
            this.textImagine.Name = "textImagine";
            this.textImagine.Size = new System.Drawing.Size(153, 132);
            this.textImagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.textImagine.TabIndex = 0;
            this.textImagine.TabStop = false;
            this.textImagine.UseTransparentBackground = true;
            this.textImagine.Click += new System.EventHandler(this.textImagine_Click);
            // 
            // ucProdus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ucProdus";
            this.Size = new System.Drawing.Size(190, 190);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textImagine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label labelNume;
        private Guna.UI2.WinForms.Guna2PictureBox textImagine;
    }
}

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Model
{
    partial class frmAdaugareProduse
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
            this.components = new System.ComponentModel.Container();
            this.cbCategorie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPret = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNume = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textImagine = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonCauta = new Guna.UI2.WinForms.Guna2Button();
            this.labelsubcategorie = new System.Windows.Forms.Label();
            this.cbSubcategorie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textImagine)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Properties.Resources.box;
            this.pictureBox1.Location = new System.Drawing.Point(27, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Size = new System.Drawing.Size(133, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(180, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(231, 35);
            this.label1.Text = "Detalii produse";
            // 
            // cbCategorie
            // 
            this.cbCategorie.BackColor = System.Drawing.Color.Transparent;
            this.cbCategorie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategorie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategorie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategorie.ItemHeight = 30;
            this.cbCategorie.Items.AddRange(new object[] {
            "Pizza",
            "Sosuri",
            "Deserturi",
            "Băuturi"});
            this.cbCategorie.Location = new System.Drawing.Point(45, 374);
            this.cbCategorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(455, 36);
            this.cbCategorie.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(45, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categorie";
            // 
            // textPret
            // 
            this.textPret.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPret.DefaultText = "";
            this.textPret.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPret.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPret.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPret.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPret.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPret.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textPret.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPret.Location = new System.Drawing.Point(561, 183);
            this.textPret.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPret.Name = "textPret";
            this.textPret.PasswordChar = '\0';
            this.textPret.PlaceholderText = "";
            this.textPret.SelectedText = "";
            this.textPret.Size = new System.Drawing.Size(456, 72);
            this.textPret.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(561, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Preț";
            // 
            // textNume
            // 
            this.textNume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNume.DefaultText = "";
            this.textNume.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textNume.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textNume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textNume.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textNume.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textNume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textNume.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textNume.Location = new System.Drawing.Point(51, 183);
            this.textNume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNume.Name = "textNume";
            this.textNume.PasswordChar = '\0';
            this.textNume.PlaceholderText = "";
            this.textNume.SelectedText = "";
            this.textNume.Size = new System.Drawing.Size(456, 72);
            this.textNume.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(51, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nume";
            // 
            // textImagine
            // 
            this.textImagine.Image = global::TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Properties.Resources.imagineProdus;
            this.textImagine.ImageRotate = 0F;
            this.textImagine.Location = new System.Drawing.Point(1075, 150);
            this.textImagine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textImagine.Name = "textImagine";
            this.textImagine.Size = new System.Drawing.Size(337, 201);
            this.textImagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.textImagine.TabIndex = 11;
            this.textImagine.TabStop = false;
            // 
            // buttonCauta
            // 
            this.buttonCauta.AutoRoundedCorners = true;
            this.buttonCauta.BorderRadius = 27;
            this.buttonCauta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCauta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCauta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCauta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCauta.FillColor = System.Drawing.Color.Silver;
            this.buttonCauta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCauta.ForeColor = System.Drawing.Color.White;
            this.buttonCauta.Location = new System.Drawing.Point(1121, 374);
            this.buttonCauta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(240, 57);
            this.buttonCauta.TabIndex = 12;
            this.buttonCauta.Text = "Caută";
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // labelsubcategorie
            // 
            this.labelsubcategorie.AutoSize = true;
            this.labelsubcategorie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsubcategorie.ForeColor = System.Drawing.Color.DimGray;
            this.labelsubcategorie.Location = new System.Drawing.Point(561, 340);
            this.labelsubcategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelsubcategorie.Name = "labelsubcategorie";
            this.labelsubcategorie.Size = new System.Drawing.Size(135, 24);
            this.labelsubcategorie.TabIndex = 14;
            this.labelsubcategorie.Text = "Subcategorie";
            this.labelsubcategorie.Visible = false;
            // 
            // cbSubcategorie
            // 
            this.cbSubcategorie.BackColor = System.Drawing.Color.Transparent;
            this.cbSubcategorie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSubcategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubcategorie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSubcategorie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSubcategorie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSubcategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSubcategorie.ItemHeight = 30;
            this.cbSubcategorie.Location = new System.Drawing.Point(561, 374);
            this.cbSubcategorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSubcategorie.Name = "cbSubcategorie";
            this.cbSubcategorie.Size = new System.Drawing.Size(449, 36);
            this.cbSubcategorie.TabIndex = 15;
            this.cbSubcategorie.Visible = false;
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // frmAdaugareProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 611);
            this.Controls.Add(this.cbSubcategorie);
            this.Controls.Add(this.labelsubcategorie);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.textImagine);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdaugareProduse";
            this.Text = "frmAdaugareProduse";
            this.Load += new System.EventHandler(this.frmAdaugareProduse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textImagine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2ComboBox cbCategorie;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox textPret;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox textNume;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox textImagine;
        private Guna.UI2.WinForms.Guna2Button buttonCauta;
        private System.Windows.Forms.Label labelsubcategorie;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubcategorie;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
    }
}
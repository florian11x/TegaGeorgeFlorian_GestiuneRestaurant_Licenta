namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Model
{
    partial class frmAdaugareClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdaugareClient));
            this.cbSofer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelSofer = new System.Windows.Forms.Label();
            this.textName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textTelefon = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSofer
            // 
            this.cbSofer.BackColor = System.Drawing.Color.Transparent;
            this.cbSofer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSofer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSofer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSofer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSofer.ItemHeight = 30;
            this.cbSofer.Items.AddRange(new object[] {
            "Casier",
            "Ospătar",
            "Îngrijitor",
            "Manager",
            "Altele"});
            this.cbSofer.Location = new System.Drawing.Point(13, 215);
            this.cbSofer.Name = "cbSofer";
            this.cbSofer.Size = new System.Drawing.Size(342, 36);
            this.cbSofer.TabIndex = 0;
            this.cbSofer.SelectedIndexChanged += new System.EventHandler(this.cbSofer_SelectedIndexChanged);
            // 
            // labelSofer
            // 
            this.labelSofer.AutoSize = true;
            this.labelSofer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSofer.ForeColor = System.Drawing.Color.DimGray;
            this.labelSofer.Location = new System.Drawing.Point(13, 188);
            this.labelSofer.Name = "labelSofer";
            this.labelSofer.Size = new System.Drawing.Size(61, 24);
            this.labelSofer.TabIndex = 3;
            this.labelSofer.Text = "Șofer";
            // 
            // textName
            // 
            this.textName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textName.DefaultText = "";
            this.textName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textName.Location = new System.Drawing.Point(13, 38);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.PlaceholderText = "";
            this.textName.SelectedText = "";
            this.textName.Size = new System.Drawing.Size(342, 57);
            this.textName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nume client";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(463, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(394, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(57, 36);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(135, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informații client";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textName);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.textTelefon);
            this.flowLayoutPanel1.Controls.Add(this.labelSofer);
            this.flowLayoutPanel1.Controls.Add(this.cbSofer);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 111);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(434, 276);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Număr de telefon client";
            // 
            // textTelefon
            // 
            this.textTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTelefon.DefaultText = "";
            this.textTelefon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textTelefon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textTelefon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTelefon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTelefon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTelefon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textTelefon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTelefon.Location = new System.Drawing.Point(13, 127);
            this.textTelefon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.PasswordChar = '\0';
            this.textTelefon.PlaceholderText = "";
            this.textTelefon.SelectedText = "";
            this.textTelefon.Size = new System.Drawing.Size(342, 57);
            this.textTelefon.TabIndex = 2;
            // 
            // frmAdaugareClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(463, 406);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdaugareClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdaugareClient";
            this.Load += new System.EventHandler(this.frmAdaugareClient_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2ComboBox cbSofer;
        private System.Windows.Forms.Label labelSofer;
        public Guna.UI2.WinForms.Guna2TextBox textName;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox textTelefon;
    }
}
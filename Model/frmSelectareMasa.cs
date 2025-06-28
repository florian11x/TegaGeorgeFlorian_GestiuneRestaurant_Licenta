using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Model
{
    public partial class frmSelectareMasa : Form
    {
        public frmSelectareMasa()
        {
            InitializeComponent();
        }

        public string NumeMasa;

        private void frmSelectareMasa_Load(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM mese";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                b.Text = row["meseNume"].ToString();
                b.Size = new Size(180, 60);
                b.BorderRadius = 30;
                b.FillColor = Color.FromArgb(169, 169, 169);
                b.HoverState.FillColor = Color.FromArgb(192, 64, 0);
                b.ForeColor = Color.White;
                b.Font = new Font("Arial", 12, FontStyle.Bold);
                b.Click += new EventHandler(b_Click);
                flowLayoutPanel1.Controls.Add(b);
            }
        }


        private void b_Click(object sender, EventArgs e)
        {
            NumeMasa = (sender as Guna.UI2.WinForms.Guna2Button).Text.ToString();
            this.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}

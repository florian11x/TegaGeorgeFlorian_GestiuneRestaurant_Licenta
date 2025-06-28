using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Model;

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta
{
    public partial class frmSelectareSubcategorieBauturi : Form
    {
        public int SelectedSubcategorieID { get; private set; } = 0; // Default: toate băuturile

        public frmSelectareSubcategorieBauturi()
        {
            InitializeComponent();
            LoadSubcategorii();
        }

        private void LoadSubcategorii()
        {
            panouSubcategorii.Controls.Clear(); 

            string qry = "SELECT subcategorieID, subcategorieNume FROM subcategorii WHERE categorieID = 37";
            DataTable dt = GetDataTable(qry);

            int yOffset = 10;

            foreach (DataRow row in dt.Rows)
            {
                
                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();

                
                btn.Text = row["subcategorieNume"].ToString();
                btn.Tag = row["subcategorieNume"].ToString();

               
                btn.Size = new Size(200, 50);
                btn.Location = new Point(10, yOffset);
                btn.BorderRadius = 20;
                btn.FillColor = Color.FromArgb(169, 169, 169); 
                btn.HoverState.FillColor = Color.FromArgb(192, 64, 0); 
                btn.ForeColor = Color.White;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;

               
                btn.Click += BtnSubcategorie_Click;

                panouSubcategorii.Controls.Add(btn);
                yOffset += 60;
            }
        }


        private void BtnSubcategorie_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender; // Obținem butonul apăsat
            string subcategorie = btn.Tag.ToString(); // Preluăm subcategoria

            frmPOS frmPrincipal = (frmPOS)Application.OpenForms["frmPOS"];

            if (frmPrincipal != null)
            {
                frmPrincipal.FiltreazaBauturi(subcategorie); // Aplică filtrul pentru subcategorie
            }

            this.Close(); // Închide fereastra curentă
        }




        private DataTable GetDataTable(string query)
        {
            using (SqlConnection con = new SqlConnection(MainClass.con.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonToatebauturile_Click(object sender, EventArgs e)
        {
            frmPOS frmPrincipal = (frmPOS)Application.OpenForms["frmPOS"];
            if (frmPrincipal != null)
            {
              
                frmPrincipal.AfiseazaToateBauturile();
            }
            this.Close();
        }

    }
}

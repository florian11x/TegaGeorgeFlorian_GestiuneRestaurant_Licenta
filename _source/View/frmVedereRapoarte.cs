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
using TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Rapoarte;

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.View
{
    public partial class frmVedereRapoarte : Form
    {
        public frmVedereRapoarte()
        {
            InitializeComponent();
            buttonVanzari.Visible = false;
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            string qry = @"Select *  from personal";

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();
            frmPrintare frm = new frmPrintare();
            raportPersonal cr = new raportPersonal();

            cr.SetDatabaseLogon("sa", "123");
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
        }

        private void buttonVanzari_Click(object sender, EventArgs e)
        {
            frmVanzari frm = new frmVanzari();
            frm.ShowDialog();
        }


        private void buttonMeniu_Click(object sender, EventArgs e)
        {
                string qry = @"
       SELECT 
        p.produseID,
        p.produseNume,      
        p.produsePret,
        p.produseImagine,
        p.categorieID,
        c.categoriiNume,
        c.OrdineAfisare     
    FROM produse p
    INNER JOIN categorii c ON p.categorieID = c.categoriiID
    ";

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();

        

            foreach (DataRow row in dt.Rows)
            {
                string categorie = row["categoriiNume"].ToString();

                switch (categorie)
                {
                    case "Pizza":
                        row["OrdineAfisare"] = 1;
                        break;
                    case "Deserturi":
                        row["OrdineAfisare"] = 2;
                        break;
                    case "Sosuri":
                        row["OrdineAfisare"] = 3;
                        break;
                    case "Bauturi":
                        row["OrdineAfisare"] = 4;
                        break;
                    default:
                        row["OrdineAfisare"] = 99;
                        break;
                }
            }

            // ✅ Setăm raportul
            frmPrintare frm = new frmPrintare();
            raportMeniu cr = new raportMeniu();
            cr.SetDatabaseLogon("sa", "123");
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
        }

    }
}

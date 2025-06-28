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

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Rapoarte
{
    public partial class frmVanzari : Form
    {
        public frmVanzari()
        {
            InitializeComponent();
        }

      
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonRaport_Click(object sender, EventArgs e)
        {
            string qry = @"SELECT * FROM comanda m
                        INNER JOIN detaliicomanda d ON m.MainID = d.MainID
                        INNER JOIN produse p ON p.produseID = d.produsID
                        INNER JOIN categorii c ON c.categoriiID = p.categorieID
                        WHERE m.Data BETWEEN @startdate AND @enddate ;
";

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);

            cmd.Parameters.AddWithValue("@startdate", Convert.ToDateTime(dateTimePicker1.Value).Date);
            cmd.Parameters.AddWithValue("@enddate", dateTimePicker2.Value.Date.AddDays(1).AddTicks(-1));

            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();
            frmPrintare frm = new frmPrintare();
            raportVanzari cr = new raportVanzari();

            cr.SetDatabaseLogon("sa", "123");
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

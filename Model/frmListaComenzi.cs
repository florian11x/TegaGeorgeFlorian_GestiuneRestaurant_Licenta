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

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Model
{
    public partial class frmListaComenzi : Form
    {
        public frmListaComenzi()
        {
            InitializeComponent();
        }

        public int MainID = 0;

        private void frmListaComenzi_Load(object sender, EventArgs e)
        {

            IncarcareDate();
        }

        private void IncarcareDate(string statusFilter = "Toate")
        {

            string qry = @"
                    SELECT MainID AS [Nr. comandă], 
                           NumeMasa, 
                           NumeOspatar, 
                           clientNume AS Client, 
                           TipComanda, 
                           Timp, 
                           StatusBucatarie, 
                           StatusBar, 
                           Total 
                    FROM comanda";


            qry += " ORDER BY MainID DESC";

            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand(qry, MainClass.con))
            {

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            guna2DataGridView1.AutoGenerateColumns = false;
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Refresh();
        }



        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }

            if (guna2DataGridView1.Columns[e.ColumnIndex].Name == "dgvOra")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    DateTime orderTime;
                    if (DateTime.TryParse(e.Value.ToString(), out orderTime))
                    {
                        e.Value = orderTime.ToString("HH:mm");
                        e.FormattingApplied = true;
                    }
                }
            }


        }


        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < guna2DataGridView1.Columns.Count)
            {
                string columnName = guna2DataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "dgvEdit")
                {
                    MainID = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvnrComanda"].Value);

                    this.Close();
                }
                else if (columnName == "dgvDel")
                {
                    MainID = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvnrComanda"].Value);

                    string qry = @"
                    SELECT * 
                    FROM comanda c 
                    INNER JOIN detaliicomanda d ON d.MainID = c.MainID 
                    INNER JOIN produse p ON p.produseID = d.produsID 
                    WHERE c.MainID = @MainID
                    ";


                    using (SqlCommand cmd = new SqlCommand(qry, MainClass.con))
                    {
                        cmd.Parameters.AddWithValue("@MainID", MainID);
                        MainClass.con.Open();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        MainClass.con.Close();

                        frmPrintare frm = new frmPrintare();
                        raportFactura cr = new raportFactura();
                        cr.SetDatabaseLogon("sa", "123");
                        cr.SetDataSource(dt);
                        frm.crystalReportViewer1.ReportSource = cr;
                        frm.crystalReportViewer1.Refresh();
                        frm.Show();
                    }
                }
            }
        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

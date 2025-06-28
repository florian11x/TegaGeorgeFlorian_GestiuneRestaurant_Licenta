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
    public partial class frmAdaugareClient : Form
    {
        public frmAdaugareClient()
        {
            InitializeComponent();
        }

        public string TipComanda = "";
        public int soferID = 0;
        public string clientNume = "";
        public int mainID = 0;

        private void frmAdaugareClient_Load(object sender, EventArgs e)
        {
            if(TipComanda=="La pachet")
            {
                labelSofer.Visible = false;
                cbSofer.Visible = false;

            }

            cbSofer.Items.Clear();
            string qry = "Select personalID 'id', personalNume 'nume' from personal where personalFunctie = 'Sofer'";


            using (SqlCommand cmd = new SqlCommand("SELECT personalID, personalNume FROM personal WHERE personalFunctie = 'Sofer'", MainClass.con))
            {
                if (MainClass.con.State == ConnectionState.Closed)
                    MainClass.con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbSofer.DataSource = dt;
                cbSofer.DisplayMember = "personalNume";
                cbSofer.ValueMember = "personalID";
                cbSofer.SelectedIndex = -1;

                if (MainClass.con.State == ConnectionState.Open)
                    MainClass.con.Close();
            }

            cbSofer.DisplayMember = "personalNume";
            cbSofer.ValueMember = "personalID";

            cbSofer.SelectedIndex = -1;

            if (mainID>0)
            {
                cbSofer.SelectedValue = soferID;
            }
        }

        private void cbSofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSofer.SelectedValue != null && int.TryParse(cbSofer.SelectedValue.ToString(), out int id))
            {
                soferID = id;
            }

        }

    }
}

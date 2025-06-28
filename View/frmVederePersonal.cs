using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Model;

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.View
{
    public partial class frmVederePersonal : frmVedereModel
    {
        public frmVederePersonal()
        {
            InitializeComponent();
            guna2TextBox1.TextChanged += textSearch_TextChanged;
        }

        private void frmVederePersonal_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = "SELECT personalID, personalNume, personalTelefon, personalFunctie FROM personal WHERE personalNume LIKE '%" + guna2TextBox1.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvId);
            lb.Items.Add(dgvNume);
            lb.Items.Add(dgvTelefon);
            lb.Items.Add(dgvFunctie);



            MainClass.LocalData(qry, guna2DataGridView1, lb);
        }

        public override void buttonAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmAdaugarePersonal());
            //frmAdaugareCategorii frm=new frmAdaugareCategorii();
            //frm.ShowDialog();
            GetData();

        }

        public void textSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmAdaugarePersonal frm = new frmAdaugarePersonal();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvId"].Value);
                frm.textName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvNume"].Value);
                frm.textTelefon.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvTelefon"].Value);
                frm.cbFunctie.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvFunctie"].Value);
                MainClass.BlurBackground(frm);
                GetData();
            }

            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                DialogResult result = MessageBox.Show("Ești sigur că vrei să ștergi?",
                                                      "Confirmare",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvId"].Value);
                    string qry = "Delete from personal where personalID=" + id + " ";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);

                    MessageBox.Show("Personal șters cu succes!",
                                    "Informație",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    GetData();
                }
            }
        }

    }
}

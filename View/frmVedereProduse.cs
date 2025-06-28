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
    public partial class frmVedereProduse : frmVedereModel
    {
        public frmVedereProduse()
        {
            InitializeComponent();
            guna2TextBox1.TextChanged += textSearch_TextChanged;
        }

        private void frmVedereProduse_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = "SELECT p.produseID, p.produseNume, p.produsePret, c.categoriiNume, s.subcategorieNume " +
                         "FROM produse p " +
                         "LEFT JOIN categorii c ON c.categoriiID = p.categorieID " +
                         "LEFT JOIN subcategorii s ON s.subcategorieID = p.subcategorieID " +
                         "WHERE produseNume LIKE '%" + guna2TextBox1.Text + "%'";

            ListBox lb = new ListBox();
            lb.Items.Add(dgvId);
            lb.Items.Add(dgvNume);
            lb.Items.Add(dgvPret);
            lb.Items.Add(dgvCategorie);
            lb.Items.Add(dgvSubcategorie); 

            MainClass.LocalData(qry, guna2DataGridView1, lb);
        }



        public override void buttonAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmAdaugareProduse());
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
                frmAdaugareProduse frm = new frmAdaugareProduse();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvId"].Value);
                frm.catID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvCatID"].Value);
                frm.cbCategorie.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvCategorie"].Value);
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
                    string qry = "Delete from produse where produseID=" + id + " ";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);

                    MessageBox.Show("Produs șters cu succes!",
                                    "Informație",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    GetData();
                }
            }
        }

    }
}

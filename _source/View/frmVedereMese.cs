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
    public partial class frmVedereMese : frmVedereModel
    {
        public frmVedereMese()
        {
            InitializeComponent();
            guna2TextBox1.TextChanged += textSearch_TextChanged;
        }

        private void frmVedreMese_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = "Select * FROM dbo.mese where meseNume like '%" + guna2TextBox1.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvId);
            lb.Items.Add(dgvNume);



            MainClass.LocalData(qry, guna2DataGridView1, lb);
        }

        public override void buttonAdd_Click(object sender, EventArgs e)
        {
            //frmAdaugareMese frm = new frmAdaugareMese();
            //frm.ShowDialog();
            MainClass.BlurBackground(new frmAdaugareMese());

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
                frmAdaugareMese frm = new frmAdaugareMese();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvId"].Value);
                frm.textName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvNume"].Value);
                frm.ShowDialog();
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
                    string qry = "Delete from dbo.mese where meseID=" + id + " ";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);

                    MessageBox.Show("Masă ștearsă cu succes!",
                                    "Informație",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    GetData();
                }
            }
        }

    }
}

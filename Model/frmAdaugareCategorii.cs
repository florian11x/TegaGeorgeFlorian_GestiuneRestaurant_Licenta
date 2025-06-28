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

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Model
{
    public partial class frmAdaugareCategorii : frmAdaugareModel
    {
        public frmAdaugareCategorii()
        {
            InitializeComponent();
        }

        private void frmAdaugareCategorii_Load(object sender, EventArgs e)
        {

        }

        public int id = 0;

        public override void buttonSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
                qry = "INSERT INTO dbo.categorii (categoriiNume) VALUES (@Name)";
            }
            else
            {
                qry = "Update dbo.categorii Set categoriiNume=@Name where categoriiID=@id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", textName.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                MessageBox.Show("Salvare reușită!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0;
                textName.Text = "";
                textName.Focus();
            }
        }


    }
}

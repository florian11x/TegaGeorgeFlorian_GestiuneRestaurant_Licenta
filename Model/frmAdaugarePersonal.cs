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
    public partial class frmAdaugarePersonal : frmAdaugareModel
    {
        public frmAdaugarePersonal()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void frmAdaugarePersonal_Load(object sender, EventArgs e)
        {

        }

        public override void buttonSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "INSERT INTO dbo.personal (personalNume, personalTelefon, personalFunctie) VALUES (@Name, @telefon, @functie)";
            }
            else
            {
                qry = "Update dbo.personal Set personalNume=@Name, personalTelefon=@telefon, personalFunctie=@functie where personalID=@id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", textName.Text);
            ht.Add("@telefon", textTelefon.Text);
            ht.Add("@functie", cbFunctie.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                MessageBox.Show("Salvare reușită!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0;
                textName.Text = "";
                textTelefon.Text = "";
                cbFunctie.SelectedIndex = -1;
                textName.Focus();
            }
        }

    }
}

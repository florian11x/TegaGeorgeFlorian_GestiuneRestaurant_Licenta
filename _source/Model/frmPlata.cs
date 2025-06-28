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
    public partial class frmPlata : Form
    {
        public frmPlata()
        {
            InitializeComponent();
        }

        public double tot = 0;
        public int MainID = 0;

        private void textSumaIncasata_TextChanged(object sender, EventArgs e)
        {
            double tot = 0;
            double incasat = 0;
            double rest = 0;

            double.TryParse(textValoareNota.Text, out tot);
            double.TryParse(textSumaIncasata.Text, out incasat);

            rest = Math.Abs(tot - incasat);

            textRest.Text = rest.ToString();

        }


        public virtual void buttonSave_Click(object sender, EventArgs e)
        {
            string qry = @"Update comanda Set Total =@total, SumaPrimita=@sumaprimita, Rest=@rest, StatusBucatarie='Plătit', StatusBar='Plătit' where MainID=@id";


            Hashtable ht = new Hashtable();
            ht.Add("@id", MainID);
            ht.Add("@total", textValoareNota.Text);
            ht.Add("@sumaprimita", textSumaIncasata.Text);
            ht.Add("@rest", textRest.Text);

          
            if (MainClass.SQl(qry, ht) > 0)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                MessageBox.Show("Salvat cu succes!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }

        }

        private void frmPlata_Load(object sender, EventArgs e)
        {
            textValoareNota.Text = tot.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

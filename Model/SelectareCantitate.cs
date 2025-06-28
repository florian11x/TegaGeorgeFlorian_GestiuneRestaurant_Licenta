using System;
using System.Windows.Forms;

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Model
{
    public partial class SelectareCantitate : Form
    {
        public int CantitateSelectata { get; private set; } = 1;

        public SelectareCantitate(string numeProdus)
        {
            InitializeComponent();
            labelProdus.Text = "Produs: " + numeProdus;
        }

        // Eveniment pentru butoanele numerice
        private void ButtonCifra_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;

            // Actualizează cantitatea
            if (labelCantitateValoare.Text == "0")
                labelCantitateValoare.Text = btn.Text;  // Înlocuiește 0 cu prima cifră
            else
                labelCantitateValoare.Text += btn.Text; // Adaugă cifrele ulterioare
        }





        
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(labelCantitateValoare.Text, out int cantitate) && cantitate > 0)
            {
                CantitateSelectata = cantitate;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduceți o cantitate validă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        // Ștergerea cantității
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (labelCantitateValoare.Text.Length > 1)
                labelCantitateValoare.Text = labelCantitateValoare.Text.Substring(0, labelCantitateValoare.Text.Length - 1);
            else
                labelCantitateValoare.Text = "0"; // Revine la 0 dacă ștergem tot
        }



        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

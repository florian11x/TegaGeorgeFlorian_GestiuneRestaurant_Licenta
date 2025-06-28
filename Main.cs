using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Model;
using TegaGeorgeFlorian_GestiuneRestaurant_Licenta.View;

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // for accessing frm main
        static Main _obj;

        public static Main Instance
        {
            get { if (_obj == null) { _obj = new Main(); } return _obj; }
        }


        //Add controls in Main Form

        public void AddControls(Form f)
        {
            PanouCentral.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            PanouCentral.Controls.Add(f);
            f.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            labelUser.Text = MainClass.USER;
            _obj = this;

            // Rolul utilizatorului curent
            string role = MainClass.USER;

            // Ascunde tab-urile în funcție de rol
            if (role == "Ospatar")
            {
                buttonAcasa.Visible = false;
                buttonCategorii.Visible = false;
                buttonProduse.Visible = false;
                buttonMese.Visible = false;
                buttonPersonal.Visible = false;
                buttonBucatarie.Visible = false;
                buttonRapoarte.Visible = false;

                buttonPos.Visible = true;
                buttonBar.Visible = false;
            }
            else if (role == "Barman")
            {
                buttonAcasa.Visible = false;
                buttonCategorii.Visible = false;
                buttonProduse.Visible = false;
                buttonMese.Visible = false;
                buttonPersonal.Visible = false;
                buttonBucatarie.Visible = false;
                buttonRapoarte.Visible = false;
                buttonPos.Visible = false;

                buttonBar.Visible = true;  // Doar butonul BAR
            }
            else if (role == "Bucatar")
            {
                buttonAcasa.Visible = false;
                buttonCategorii.Visible = false;
                buttonProduse.Visible = false;
                buttonMese.Visible = false;
                buttonPersonal.Visible = false;
                buttonPos.Visible = false;
                buttonRapoarte.Visible = false;
                buttonBar.Visible = false;

                buttonBucatarie.Visible = true;  // Bucătarul vede doar Bucătăria
            }
            else if (role == "Manager")
            {
                // Managerul are acces la toate tab-urile
                buttonAcasa.Visible = false;
                buttonCategorii.Visible = true;
                buttonProduse.Visible = true;
                buttonMese.Visible = true;
                buttonPersonal.Visible = true;
                buttonPos.Visible = true;
                buttonBucatarie.Visible = true;
                buttonRapoarte.Visible = true;
            }
        }


        private void buttonAcasa_Click(object sender, EventArgs e)
        {
            AddControls(new formAcasa());
        }

        private void PanouCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCategorii_Click(object sender, EventArgs e)
        {
            AddControls(new frmVedereCategorii());
        }

        private void buttonMese_Click(object sender, EventArgs e)
        {
            AddControls(new frmVedereMese());
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            AddControls(new frmVederePersonal());
        }

        private void buttonProduse_Click(object sender, EventArgs e)
        {
            AddControls(new frmVedereProduse());
        }

        private void buttonPos_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.Show();
        }

        private void buttonBucatarie_Click(object sender, EventArgs e)
        {
            AddControls(new frmVedereBucatarie());
        }

        private void buttonRapoarte_Click(object sender, EventArgs e)
        {
            AddControls(new frmVedereRapoarte());
        }

        private void buttonBar_Click(object sender, EventArgs e)
        {
            AddControls(new frmVedereBar());
        }
    }
}

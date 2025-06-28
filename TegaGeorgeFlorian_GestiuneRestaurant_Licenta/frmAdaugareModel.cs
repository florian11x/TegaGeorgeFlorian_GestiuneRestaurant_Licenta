using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta
{
    public partial class frmAdaugareModel : Form
    {
        public frmAdaugareModel()
        {
            InitializeComponent();
        }

        public virtual void buttonSave_Click(object sender, EventArgs e)
        {

        }


        public virtual void buttonClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void frmAdaugareModel_Load(object sender, EventArgs e)
        {

        }
       
    }
}

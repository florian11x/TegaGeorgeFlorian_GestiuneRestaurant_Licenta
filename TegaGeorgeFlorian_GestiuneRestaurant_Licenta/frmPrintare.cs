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
    public partial class frmPrintare : Form
    {
        public frmPrintare()
        {
            InitializeComponent();
        }

        private void frmPrintare_Load(object sender, EventArgs e)
        {
            buttonMax.PerformClick();
        }
    }
}

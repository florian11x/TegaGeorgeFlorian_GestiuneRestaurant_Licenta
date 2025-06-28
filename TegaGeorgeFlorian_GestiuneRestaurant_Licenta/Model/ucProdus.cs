using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Model
{
    

    public partial class ucProdus : UserControl
    {
        public ucProdus()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;

        public int id { get; set; }

        public string produsPret { get; set; }

        public string produsCategorie { get; set; }

        public string produsSubcategorie { get; set; }


        public string produsNume
        {
            get { return labelNume.Text; }
            set { labelNume.Text = value; }
        }

        public Image produsImagine
        {
            get { return textImagine.Image; }
            set { textImagine.Image = value; }
        }

        private void textImagine_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

    }
}

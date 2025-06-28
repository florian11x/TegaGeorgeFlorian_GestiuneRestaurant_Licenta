using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(textUser.Text, textPassword.Text) == false)
            {
                guna2MessageDialog1.Show("Invalid username or password!");
                return;
            }
            else
            {
                this.Hide();
                Main m = new Main();
                m.Show();
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

           
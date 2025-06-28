using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;


namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta
{
    class MainClass
    {
        public static readonly string con_string = "Data Source=DESKTOP-HCU8Q5J\\SQLEXPRESS;Initial Catalog=database1;Integrated Security=True; User ID=sa; Password=123";
        public static SqlConnection con = new SqlConnection(con_string);


        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }


        
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;

            string hashedPass = ComputeSha256Hash(pass); // generăm hash-ul SHA-256 al parolei introduse

            string qry = "SELECT * FROM dbo.users WHERE username = @username AND upass = @upass";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@upass", hashedPass);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["uName"].ToString();
            }

            return isValid;
        }


        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }

        public static int SQl(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry,con);
                cmd.CommandType = CommandType.Text;

                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                res= cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

            return res;
        }


        //Incarcare date din database

        public static void LocalData(string qry, DataGridView gv, ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string columnName1=((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[columnName1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource=dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

        }
        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = Main.Instance.Size;
                Background.Location = Main.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }

        public static void CBFill(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Columns.Contains("id") && dt.Columns.Contains("name"))
            {
                cb.DataSource = dt;
                cb.DisplayMember = "name";
                cb.ValueMember = "id";
                cb.SelectedIndex = -1;
            }
        }



    }


}
   

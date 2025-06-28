using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.View
{
    public partial class frmVedereBucatarie : Form
    {
        public frmVedereBucatarie()
        {
            InitializeComponent();
        }

        private void frmVedereBucatarie_Load(object sender, EventArgs e)
        {
            PrimireComenzi();
        }

        private void PrimireComenzi()
        {
            flowLayoutPanel1.Controls.Clear();

            string qry1 = @"
                SELECT DISTINCT c.*
                FROM comanda c
                WHERE EXISTS (
                SELECT 1
                FROM detaliicomanda d
                JOIN produse p ON p.produseID = d.produsID
                WHERE d.MainID = c.MainID
                  AND p.categorieID <> 37
                  AND d.isNewItem = 1)";


            SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt1);

            FlowLayoutPanel p1;
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 420;
                p1.Height = 450;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(20);
                p1.BackColor = Color.WhiteSmoke;
                p1.Padding = new Padding(15);

                FlowLayoutPanel p2 = new FlowLayoutPanel();
                p2.BackColor = Color.White;
                p2.AutoSize = true;
                p2.Width = 380;
                p2.Height = 200;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.Margin = new Padding(5);
                p2.Padding = new Padding(10);

                Label lbl1 = new Label();
                lbl1.ForeColor = Color.Black;
                lbl1.Margin = new Padding(5);
                lbl1.AutoSize = true;
                lbl1.Font = new Font("Segoe UI", 14, FontStyle.Regular);

                Label lbl2 = new Label();
                lbl2.ForeColor = Color.Black;
                lbl2.Margin = new Padding(5);
                lbl2.AutoSize = true;
                lbl2.Font = new Font("Segoe UI", 12, FontStyle.Regular);

                Label lbl3 = new Label();
                lbl3.ForeColor = Color.Black;
                lbl3.Margin = new Padding(5);
                lbl3.AutoSize = true;
                lbl3.Font = new Font("Segoe UI", 12, FontStyle.Regular);

                Label lbl4 = new Label();
                lbl4.ForeColor = Color.Black;
                lbl4.Margin = new Padding(5);
                lbl4.AutoSize = true;
                lbl4.Font = new Font("Segoe UI", 12, FontStyle.Italic);

                lbl1.Text = "🍽️ Masa: " + dt1.Rows[i]["NumeMasa"].ToString();
                lbl2.Text = "👨‍🍳 Ospătar: " + dt1.Rows[i]["NumeOspatar"].ToString();
                lbl3.Text = "⏰ Ora: " + dt1.Rows[i]["Timp"].ToString();
                lbl4.Text = "📋 Tip Comandă: " + dt1.Rows[i]["TipComanda"].ToString();

                p2.Controls.Add(lbl1);
                p2.Controls.Add(lbl2);
                p2.Controls.Add(lbl3);
                p2.Controls.Add(lbl4);

                p1.Controls.Add(p2);

               

                int mid = 0;
                mid = Convert.ToInt32(dt1.Rows[i]["MainID"].ToString());

                string qry2 = @"
                SELECT p.produseNume, d.cantitate, d.isNewItem
                FROM detaliicomanda d
                JOIN produse p ON p.produseID = d.produsID
                WHERE d.MainID = " + mid + " AND p.categorieID <> 37";
       
                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);
                if (dt2.Rows.Count == 0)
                    continue;


                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    Label lbl5 = new Label();
                    bool esteNou = Convert.ToInt32(dt2.Rows[j]["isNewItem"]) == 1;
                    lbl5.ForeColor = esteNou ? Color.Green : Color.Black;

                    lbl5.Margin = new Padding(10, 5, 3, 5); 
                    lbl5.AutoSize = true;
                    lbl5.Font = new Font("Segoe UI", 12, FontStyle.Bold); 

                    lbl5.Text = "• " + dt2.Rows[j]["produseNume"].ToString() + " x " + dt2.Rows[j]["cantitate"].ToString();

                    p1.Controls.Add(lbl5);
                }


                // adaugare buton schimbare status comanda 

                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                b.AutoRoundedCorners = true;
                b.Size = new Size(120, 45);
                b.FillColor = Color.Gray;
                b.Margin = new Padding(60, 5, 3, 10);
                b.Text = "Finalizat";
                b.Tag = dt1.Rows[i]["MainID"].ToString();

                b.Click += new EventHandler(b_click);

                p1.Controls.Add(b);


                flowLayoutPanel1.Controls.Add(p1);
            }

        }
        private void b_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Guna.UI2.WinForms.Guna2Button).Tag.ToString());

            DialogResult result = MessageBox.Show("Ești sigur că vrei să finalizezi comanda?",
                                                  "Confirmare",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string qryComanda = @"UPDATE comanda SET StatusBucatarie = 'Finalizat' WHERE MainID = @ID";
                string qryDetalii = @"
                        UPDATE detaliicomanda
                        SET isNewItem = 0
                        WHERE MainID = @ID
                        AND isNewItem = 1
                        AND produsID IN (
                            SELECT produseID FROM produse WHERE categorieID <> 37
                        )";


                Hashtable ht = new Hashtable();
                ht.Add("@ID", id);

                if (MainClass.SQl(qryComanda, ht) > 0)
                {
                    MainClass.SQl(qryDetalii, ht); 
                    MessageBox.Show("Comanda a fost finalizată!",
                                    "Succes",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                PrimireComenzi(); 
            }
        }


    }
}

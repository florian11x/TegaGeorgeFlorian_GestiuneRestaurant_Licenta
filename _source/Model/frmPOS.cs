using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TegaGeorgeFlorian_GestiuneRestaurant_Licenta.View;



namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Model
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        public string TipComanda = "";
        public int soferID = 0;
        public string clientNume = "";
        public string clientTelefon = "";

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AdaugareCategorii();

            PanouProduse.Controls.Clear();
            IncarcareProduse();
        }

        private void AdaugareCategorii()
        {
            string qry = "Select * from categorii";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            PanouCategorii.Controls.Clear();

            // Adaugă butonul "Toate categoriile"
            Guna.UI2.WinForms.Guna2Button btnToateCategoriile = new Guna.UI2.WinForms.Guna2Button();
            btnToateCategoriile.Text = "Toate categoriile";
            btnToateCategoriile.Size = new Size(180, 60);
            btnToateCategoriile.BorderRadius = 30;
            btnToateCategoriile.FillColor = Color.FromArgb(192, 64, 0); ;
            btnToateCategoriile.HoverState.FillColor = Color.FromArgb(192, 64, 0);
            btnToateCategoriile.ForeColor = Color.White;
            btnToateCategoriile.Font = new Font("Arial", 12, FontStyle.Bold);
            btnToateCategoriile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnToateCategoriile.Click += b_Click;

            PanouCategorii.Controls.Add(btnToateCategoriile);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.Text = row["categoriiNume"].ToString();
                    b.Size = new Size(180, 60);
                    b.BorderRadius = 30;
                    b.FillColor = Color.FromArgb(169, 169, 169);
                    b.HoverState.FillColor = Color.FromArgb(192, 64, 0);
                    b.ForeColor = Color.White;
                    b.Font = new Font("Arial", 12, FontStyle.Bold);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;


                    string categorieNume = row["categoriiNume"].ToString();

                    if (categorieNume == "Bauturi")
                    {
                        b.Click += new EventHandler(Bauturi_Click);
                    }
                    else
                    {
                        b.Click += new EventHandler(b_Click);
                    }

                    PanouCategorii.Controls.Add(b);
                }

            }
        }



        private void Bauturi_Click(object sender, EventArgs e)
        {
            // Deschide fereastra pentru selectarea subcategoriilor de băuturi
            frmSelectareSubcategorieBauturi frmSubcategorii = new frmSelectareSubcategorieBauturi();
            frmSubcategorii.ShowDialog();
        }

        private void b_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            if (b.Text == "Toate categoriile")
            {
                textCautare.Text = "1";
                textCautare.Text = "";
                return;
            }

            foreach (var item in PanouProduse.Controls)
            {
                var pro = (ucProdus)item;
                pro.Visible = pro.produsCategorie.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id, string produsID, string nume, string categorie, string subcategorie, string pret, Image imagine)
        {
            var w = new ucProdus()
            {
                produsNume = nume,
                produsPret = pret,
                produsCategorie = categorie,
                produsSubcategorie = subcategorie,
                produsImagine = imagine,
                id = Convert.ToInt32(produsID)
            };

            PanouProduse.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProdus)ss;

                // Deschide fereastra pentru selectarea cantității
                SelectareCantitate frmCantitate = new SelectareCantitate(wdg.produsNume);
                if (frmCantitate.ShowDialog() == DialogResult.OK)
                {
                    int cantitateSelectata = frmCantitate.CantitateSelectata;

                    // Verificăm dacă produsul există deja în comandă
                    foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                    {
                        if (Convert.ToInt32(item.Cells["dgvprodusID"].Value) == wdg.id)
                        {
                            item.Cells["dgvCantitate"].Value = int.Parse(item.Cells["dgvCantitate"].Value.ToString()) + cantitateSelectata;
                            item.Cells["dgvTotal"].Value = int.Parse(item.Cells["dgvCantitate"].Value.ToString()) *
                                                               double.Parse(item.Cells["dgvPret"].Value.ToString());

                            GetTotal();
                            return;
                        }
                    }

                    // Adăugăm un produs nou în listă
                    guna2DataGridView1.Rows.Add(new object[] { 0, 0, wdg.id, wdg.produsNume, cantitateSelectata, wdg.produsPret, cantitateSelectata * double.Parse(wdg.produsPret) });
                    GetTotal();
                }
            };


        }

        // Getting product from database
        private void IncarcareProduse()
        {
            string qry = @"SELECT p.*, c.categoriiNume, s.subcategorieNume 
              FROM dbo.produse p
              LEFT JOIN dbo.categorii c ON c.categoriiID = p.categorieID
              LEFT JOIN dbo.subcategorii s ON s.subcategorieID = p.subcategorieID";

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["produseImagine"];
                byte[] imagebytearray = imagearray;

               AddItems("0", item["produseID"].ToString(), item["produseNume"].ToString(), item["categoriiNume"].ToString(), item["subcategorieNume"].ToString(), item["produsePret"].ToString(), Image.FromStream(new MemoryStream(imagearray)));


            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in PanouProduse.Controls)
            {
                var pro = (ucProdus)item;
                pro.Visible = pro.produsNume.ToLower().Contains(textCautare.Text.Trim().ToLower());
            }
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void GetTotal()
        {
            double total = 0;
            labelTotal.Text = "";

            foreach (DataGridViewRow item in guna2DataGridView1.Rows)
            {
                total += double.Parse(item.Cells["dgvTotal"].Value.ToString());
            }

            labelTotal.Text = total.ToString("N2");
        }

        private void buttonNou_Click(object sender, EventArgs e)
        {
            labelMasa.Text = "";
            labelOspatar.Text = "";
            labelMasa.Visible = false;
            labelOspatar.Visible = false;
            guna2DataGridView1.Rows.Clear();
            MainID = 0;
            labelTotal.Text = "00";
        }

        private void buttonLivrare_Click(object sender, EventArgs e)
        {
            labelMasa.Text = "";
            labelOspatar.Text = "";
            labelMasa.Visible = false;
            labelOspatar.Visible = false;
            TipComanda = "Livrare";

            frmAdaugareClient frm = new frmAdaugareClient();
            frm.mainID = MainID;
            frm.TipComanda = TipComanda;
            MainClass.BlurBackground(frm);


            if (frm.textName.Text != "") 
            {
                soferID = frm.soferID;
                labelNumeSofer.Text = "   Nume client: " + frm.textName.Text + "   Numar de telefon client: " + frm.textTelefon.Text + "   Sofer: " + frm.cbSofer.Text;
                labelNumeSofer.Visible = true;
                clientNume = frm.textName.Text;
                clientTelefon = frm.textTelefon.Text;
            }
        }

        private void buttonPachet_Click(object sender, EventArgs e)
        {
            labelMasa.Text = "";
            labelOspatar.Text = "";
            labelMasa.Visible = false;
            labelOspatar.Visible = false;
            TipComanda = "La pachet";

            frmAdaugareClient frm = new frmAdaugareClient();
            frm.mainID = MainID;
            frm.TipComanda = TipComanda;
            MainClass.BlurBackground(frm);

            if (frm.textName.Text != "") 
            {
                soferID = frm.soferID;
                labelNumeSofer.Text = "   Nume client: " + frm.textName.Text + "   Numar de telefon client : " + frm.textTelefon.Text;
                labelNumeSofer.Visible = true;
                clientNume = frm.textName.Text;
                clientTelefon = frm.textTelefon.Text;
            }
        }

        private void buttonAici_Click(object sender, EventArgs e)
        {
            TipComanda = "Servire aici";
            labelNumeSofer.Visible = false;
            frmSelectareMasa frm = new frmSelectareMasa();
            MainClass.BlurBackground(frm);
            if (frm.NumeMasa != "")
            {
                labelMasa.Text = frm.NumeMasa;
                labelMasa.Visible = true;
            }
            else
            {
                labelMasa.Text = "";
                labelMasa.Visible = false;
            }

            frmSelectareOspatar frm2 = new frmSelectareOspatar();
            MainClass.BlurBackground(frm2);
            if (frm2.NumeOspatar != "")
            {
                labelOspatar.Text = frm2.NumeOspatar;
                labelOspatar.Visible = true;
            }
            else
            {
                labelOspatar.Text = "";
                labelOspatar.Visible = false;
            }

        }

        private void buttonComanda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TipComanda))
            {
                MessageBox.Show("Selectați tipul comenzii (Servire aici, La pachet, Livrare)!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TipComanda == "Servire aici" && (string.IsNullOrEmpty(labelMasa.Text) || string.IsNullOrEmpty(labelOspatar.Text)))
            {
                MessageBox.Show("Selectați atât ospătarul, cât și masa înainte de a trimite comanda!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (guna2DataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nu puteți trimite o comandă goală!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string qry1 = ""; //main table
            string qry2 = ""; // detail table

            int detaliuID = 0;

            bool areMancare = false;
            bool areBauturi = false;


            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                int detaliuIDNou = Convert.ToInt32(row.Cells["dgvId"].Value);
                if (detaliuIDNou != 0) continue;

                int produsID = Convert.ToInt32(row.Cells["dgvprodusID"].Value);

                string cat = null;
                using (SqlCommand cmdCat = new SqlCommand(@"
            SELECT c.categoriiNume 
            FROM produse p 
            JOIN categorii c ON p.categorieID = c.categoriiID 
            WHERE p.produseID = @id", MainClass.con))
                {
                    cmdCat.Parameters.AddWithValue("@id", produsID);

                    if (MainClass.con.State == ConnectionState.Closed)
                        MainClass.con.Open();

                    cat = cmdCat.ExecuteScalar()?.ToString()?.Trim();

                    if (MainClass.con.State == ConnectionState.Open)
                        MainClass.con.Close();
                }

                if (string.IsNullOrEmpty(cat)) continue;

                if (cat.Equals("Bauturi", StringComparison.OrdinalIgnoreCase))
                    areBauturi = true;
                else
                    areMancare = true;
            }


            if (MainID == 0)
            {
                qry1 = @"INSERT INTO comanda (Data, Timp, NumeMasa, NumeOspatar, StatusBucatarie, StatusBar, TipComanda, Total, SumaPrimita, Rest, soferID, clientNume, clientTelefon) 
                        VALUES (@Data, @Timp, @NumeMasa, @NumeOspatar, @StatusBucatarie, @StatusBar, @TipComanda, @Total, @SumaPrimita, @Rest, @soferID, @clientNume, @clientTelefon);
                        SELECT SCOPE_IDENTITY();";

            }
            else
            {
                List<string> updateFields = new List<string>();

                if (areMancare)
                    updateFields.Add("StatusBucatarie = 'În asteptare'");
                if (areBauturi)
                    updateFields.Add("StatusBar = 'În asteptare'");

                updateFields.Add("Total = @Total");
                updateFields.Add("SumaPrimita = @SumaPrimita");
                updateFields.Add("Rest = @Rest");

                qry1 = "UPDATE comanda SET " + string.Join(", ", updateFields) + " WHERE MainID = @ID";

            }





            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);

            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@Timp", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@NumeMasa", labelMasa.Text);
            cmd.Parameters.AddWithValue("@NumeOspatar", labelOspatar.Text);
            if (MainID == 0)
            {
                if (areMancare)
                    cmd.Parameters.AddWithValue("@StatusBucatarie", "În asteptare");
                else
                    cmd.Parameters.AddWithValue("@StatusBucatarie", DBNull.Value);

                if (areBauturi)
                    cmd.Parameters.AddWithValue("@StatusBar", "În asteptare");
                else
                    cmd.Parameters.AddWithValue("@StatusBar", DBNull.Value);
            }

            cmd.Parameters.AddWithValue("@TipComanda", TipComanda);
            cmd.Parameters.AddWithValue("@Total", Convert.ToDouble(labelTotal.Text));
            cmd.Parameters.AddWithValue("@SumaPrimita", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@Rest", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@soferID", soferID);
            cmd.Parameters.AddWithValue("@clientNume", clientNume);
            cmd.Parameters.AddWithValue("@clientTelefon", clientTelefon);

            if (MainClass.con.State == ConnectionState.Closed)
            {
                MainClass.con.Open();
            }

            if (MainID == 0)
            {
                MainID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                cmd.ExecuteNonQuery();
            }


            if (MainClass.con.State == ConnectionState.Open)
            {
                MainClass.con.Close();
            }

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detaliuID = Convert.ToInt32(row.Cells["dgvId"].Value);

                if (detaliuID == 0)
                {
                    qry2 = @"INSERT INTO detaliicomanda (MainID, produsID, cantitate, pret, suma, isNewItem) 
                    VALUES (@MainID, @produsID, @cantitate, @pret, @suma, @isNewItem);";

                }
                else
                {
                    qry2 = @"Update detaliicomanda Set produsID=@produsID, cantitate=@cantitate,pret=@pret,suma=@suma where DetaliuID=@ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);

                cmd2.Parameters.AddWithValue("@ID", detaliuID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@produsID", Convert.ToInt32(row.Cells["dgvprodusID"].Value));
                cmd2.Parameters.AddWithValue("@cantitate", Convert.ToInt32(row.Cells["dgvCantitate"].Value));
                cmd2.Parameters.AddWithValue("@pret", Convert.ToDouble(row.Cells["dgvPret"].Value));
                cmd2.Parameters.AddWithValue("@suma", Convert.ToDouble(row.Cells["dgvTotal"].Value));
                cmd2.Parameters.AddWithValue("@isNewItem", 1);





                if (MainClass.con.State == ConnectionState.Closed)
                {
                    MainClass.con.Open();
                }

                cmd2.ExecuteNonQuery();

                if (MainClass.con.State == ConnectionState.Open)
                {
                    MainClass.con.Close();
                }

            }
            MessageBox.Show("Salvat cu succes!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MainID = 0;
            detaliuID = 0;
            guna2DataGridView1.Rows.Clear();
            labelMasa.Text = "";
            labelOspatar.Text = "";
            labelMasa.Visible = false;
            labelOspatar.Visible = false;
            labelTotal.Text = "00";
            labelNumeSofer.Text = "";
        }

        public int id = 0;

        private void buttonLista_Click(object sender, EventArgs e)
        {
            frmListaComenzi frm = new frmListaComenzi();
            MainClass.BlurBackground(frm);

            if (frm.MainID > 0)
            {
                id = frm.MainID;
                MainID = frm.MainID;
                IncarcareIntrari();
            }
        }

        private void IncarcareIntrari()
        {
            string qry = @"Select * from comanda c
                inner join detaliicomanda d on c.MainID = d.MainID
                inner join produse p on p.produseID = d.produsID
                Where c.MainID = " + id + "";


            SqlCommand cmd2 = new SqlCommand(qry, MainClass.con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);


            if (dt2.Rows[0]["TipComanda"].ToString() == "Livrare")
            {
                buttonLivrare.Checked = true;
                labelOspatar.Visible = false;
                labelMasa.Visible = false;
            }
            else if (dt2.Rows[0]["TipComanda"].ToString() == "La pachet")
            {
                buttonPachet.Checked = true;
                labelOspatar.Visible = false;
                labelMasa.Visible = false;
            }
            else
            {
                buttonAici.Checked = true;
                labelOspatar.Visible = true;
                labelMasa.Visible = true;
            }



          guna2DataGridView1.Rows.Clear();

            foreach (DataRow item in dt2.Rows)
            {
                labelMasa.Text = item["NumeMasa"].ToString();
                labelOspatar.Text = item["NumeOspatar"].ToString();


                string detaliuId = item["DetaliuID"].ToString();
                string produsNume = item["produseNume"].ToString();
                string produsID = item["produsID"].ToString();
                string cantitate = item["cantitate"].ToString();
                string pret = item["pret"].ToString();
                string suma = item["suma"].ToString();


                object[] obj = { 0, detaliuId, produsID, produsNume, cantitate, pret, suma };
                guna2DataGridView1.Rows.Add(obj);
            }
            GetTotal();
        }

        private void buttonPlata_Click(object sender, EventArgs e)
        {
            frmPlata frm = new frmPlata();
            frm.MainID = id;
            frm.tot = Convert.ToDouble(labelTotal.Text);
            MainClass.BlurBackground(frm);

            MainID = 0;
            guna2DataGridView1.Rows.Clear();
            labelMasa.Text = "";
            labelOspatar.Text = "";
            labelMasa.Visible = false;
            labelOspatar.Visible = false;
            labelTotal.Text = "00";
        }

        private void buttonAsteptare_Click(object sender, EventArgs e)
        {
            string qry1 = ""; //main table
            string qry2 = ""; // detail table

            int detaliuID = 0;

            if (TipComanda == "")
            {
                MessageBox.Show("Selectați tipul comenzii!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MainID == 0)
            {
                qry1 = @"INSERT INTO comanda (Data, Timp, NumeMasa, NumeOspatar, StatusBucatarie, StatusBar, TipComanda, Total, SumaPrimita, Rest, soferID, clientNume, clientTelefon) 
                        VALUES (@Data, @Timp, @NumeMasa, @NumeOspatar, @StatusBucatarie, @StatusBar, @TipComanda, @Total, @SumaPrimita, @Rest, @soferID, @clientNume, @clientTelefon);
                        SELECT SCOPE_IDENTITY();";

            }
            else
            {
                qry1 = @"Update comanda Set StatusBucatarie=@StatusBucatarie, StatusBar=@StatusBar, Total=@Total, SumaPrimita=@SumaPrimita, Rest=@Rest where MainID=@ID";

            }



            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);

            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@Timp", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@NumeMasa", labelMasa.Text);
            cmd.Parameters.AddWithValue("@NumeOspatar", labelOspatar.Text);
            cmd.Parameters.AddWithValue("@StatusBucatarie", "Retinut");
            cmd.Parameters.AddWithValue("@StatusBar", "Retinut");
            cmd.Parameters.AddWithValue("@TipComanda", TipComanda);
            cmd.Parameters.AddWithValue("@Total", Convert.ToDouble(labelTotal.Text));
            cmd.Parameters.AddWithValue("@SumaPrimita", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@Rest", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@soferID", soferID);
            cmd.Parameters.AddWithValue("@clientNume", clientNume);
            cmd.Parameters.AddWithValue("@clientTelefon", clientTelefon);

            if (MainClass.con.State == ConnectionState.Closed)
            {
                MainClass.con.Open();
            }

            if (MainID == 0)
            {
                MainID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                cmd.ExecuteNonQuery();
            }

            if (MainClass.con.State == ConnectionState.Open)
            {
                MainClass.con.Close();
            }

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detaliuID = Convert.ToInt32(row.Cells["dgvId"].Value);

                if (detaliuID == 0)
                {
                    qry2 = @"INSERT INTO detaliicomanda (MainID, produsID, cantitate, pret, suma) 
                            VALUES (@MainID, @produsID, @cantitate, @pret, @suma);";

                }
                else
                {
                    qry2 = @"Update detaliicomanda Set produsID=@produsID, cantitate=@cantitate,pret=@pret,suma=@suma where DetaliuID=@ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);

                cmd2.Parameters.AddWithValue("@ID", detaliuID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@produsID", Convert.ToInt32(row.Cells["dgvprodusID"].Value));
                cmd2.Parameters.AddWithValue("@cantitate", Convert.ToInt32(row.Cells["dgvCantitate"].Value));
                cmd2.Parameters.AddWithValue("@pret", Convert.ToDouble(row.Cells["dgvPret"].Value));
                cmd2.Parameters.AddWithValue("@suma", Convert.ToDouble(row.Cells["dgvTotal"].Value));


                if (MainClass.con.State == ConnectionState.Closed)
                {
                    MainClass.con.Open();
                }

                cmd2.ExecuteNonQuery();

                if (MainClass.con.State == ConnectionState.Open)
                {
                    MainClass.con.Close();
                }

            }
            MessageBox.Show("Salvat cu succes!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MainID = 0;
            detaliuID = 0;
            guna2DataGridView1.Rows.Clear();
            labelMasa.Text = "";
            labelOspatar.Text = "";
            labelMasa.Visible = false;
            labelOspatar.Visible = false;
            labelTotal.Text = "00";
            labelNumeSofer.Text = "";
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificăm dacă am dat click pe o celulă validă
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificăm dacă am dat click pe coloana de editare
                if (guna2DataGridView1.Columns[e.ColumnIndex].Name == "dgvEditare")
                {
                    string numeProdus = guna2DataGridView1.Rows[e.RowIndex].Cells["dgvNume"].Value.ToString();
                    SelectareCantitate selectareCantitate = new SelectareCantitate(numeProdus);

                    if (selectareCantitate.ShowDialog() == DialogResult.OK)
                    {
                        int cantitateNoua = selectareCantitate.CantitateSelectata;
                        guna2DataGridView1.Rows[e.RowIndex].Cells["dgvCantitate"].Value = cantitateNoua;

                        // Actualizare preț și sumă
                        int pret = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["dgvPret"].Value);
                        guna2DataGridView1.Rows[e.RowIndex].Cells["dgvTotal"].Value = cantitateNoua * pret;

                        // Actualizare total
                        ActualizeazaTotal();
                    }
                }

                // Verificăm dacă am dat click pe coloana de ștergere
                if (guna2DataGridView1.Columns[e.ColumnIndex].Name == "dgvStergere")
                {
                    DialogResult result = MessageBox.Show("Ești sigur că vrei să ștergi acest produs?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        guna2DataGridView1.Rows.RemoveAt(e.RowIndex);
                        GetTotal();
                    }
                }
            }
        }

        private void ActualizeazaTotal()
        {
            int total = 0;
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.Cells["dgvTotal"].Value != null)
                {
                    total += Convert.ToInt32(row.Cells["dgvTotal"].Value);
                }
            }
            labelTotal.Text = total.ToString("N2");
        }


        public void AfiseazaToateBauturile()
        {


            foreach (var item in PanouProduse.Controls)
            {
                if (item is ucProdus pro)
                {
                    string categorie = pro.produsCategorie.Trim().ToLower(); // Elimină spațiile înainte și după

                    if (categorie == "bauturi") // Comparăm exact
                    {
                        pro.Visible = true;

                    }
                    else
                    {
                        pro.Visible = false;
                    }
                }
            }

            PanouProduse.Refresh(); // Asigură că UI-ul se actualizează
        }

        public void FiltreazaBauturi(string subcategorie)
        {



            foreach (var item in PanouProduse.Controls)
            {
                if (item is ucProdus pro)
                {
                    if (pro.produsSubcategorie.Trim().ToLower() == subcategorie.ToLower())
                    {
                        pro.Visible = true;


                    }
                    else
                    {
                        pro.Visible = false;
                    }
                }
            }

            PanouProduse.Refresh(); // Actualizează UI-ul


        }


    }
}

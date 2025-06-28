using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TegaGeorgeFlorian_GestiuneRestaurant_Licenta.Model
{
    public partial class frmAdaugareProduse : frmAdaugareModel
    {
        public frmAdaugareProduse()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int catID = 0;
       

        private void frmAdaugareProduse_Load(object sender, EventArgs e)
        {
            string qry = "Select categoriiID 'id', categoriiNume 'name'  from categorii";
            MainClass.CBFill(qry, cbCategorie);

            if(catID>0) //Update
            {
                cbCategorie.SelectedValue = catID;
            }

            if(id>0)
            {
                ForUpdateLoadData();
            }
            cbCategorie.SelectedIndexChanged += cbCategorie_SelectedIndexChanged;

        }

        string filePath;
        Byte[] imageByteArray;

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|*.png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                textImagine.Image = new Bitmap(filePath);
            }
        }

        public override void buttonSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0) // Adăugare produs nou
            {
                qry = "INSERT INTO produse (produseNume, produsePret, categorieID, subcategorieID, produseImagine) " +
                      "VALUES (@Name, @pret, @categorie, @subcategorie, @imagine)";
            }
            else // Modificare produs existent
            {
                qry = "UPDATE produse SET produseNume=@Name, produsePret=@pret, categorieID=@categorie, " +
                      "subcategorieID=@subcategorie, produseImagine=@imagine WHERE produseID=@id";
            }

            // Convertire imagine în byte array
            Image temp = new Bitmap(textImagine.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", textNume.Text);
            ht.Add("@pret", textPret.Text);
            ht.Add("@categorie", Convert.ToInt32(cbCategorie.SelectedValue));

            // Salvăm subcategoria doar dacă este vizibilă
            if (cbSubcategorie.Visible && cbSubcategorie.SelectedIndex != -1)
            {
                ht.Add("@subcategorie", Convert.ToInt32(cbSubcategorie.SelectedValue));
            }
            else
            {
                ht.Add("@subcategorie", DBNull.Value);
            }

            ht.Add("@imagine", imageByteArray);

            if (MainClass.SQl(qry, ht) > 0)
            {
                MessageBox.Show("Salvare reușită!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
        }

        private void ResetForm()
        {
            id = 0;
            textNume.Text = "";
            textPret.Text = "";
            cbCategorie.SelectedIndex = -1;
            cbSubcategorie.SelectedIndex = -1;
            cbSubcategorie.Visible = false;
            labelsubcategorie.Visible = false;
            textImagine.Image = Properties.Resources.imagineProdus; 
            textNume.Focus();
        }



        private void ForUpdateLoadData()
        {
            string qry = "SELECT * FROM produse WHERE produseID = " + id;
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                textNume.Text = dt.Rows[0]["produseNume"].ToString();
                textPret.Text = dt.Rows[0]["produsePret"].ToString();

                cbCategorie.SelectedValue = Convert.ToInt32(dt.Rows[0]["categorieID"]);


                if (dt.Rows[0]["subcategorieID"] != DBNull.Value)
                {
                    int subcategorieID = Convert.ToInt32(dt.Rows[0]["subcategorieID"]);
                    LoadSubcategorii(Convert.ToInt32(dt.Rows[0]["categorieID"]));
                    cbSubcategorie.SelectedValue = subcategorieID;
                    cbSubcategorie.Visible = true;
                    labelsubcategorie.Visible = true;
                }
                else
                {
                    cbSubcategorie.SelectedIndex = -1;
                    cbSubcategorie.Visible = false;
                    labelsubcategorie.Visible = false;
                }

                Byte[] imageArray = (byte[])(dt.Rows[0]["produseImagine"]);
                textImagine.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }


        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorie.SelectedItem != null)
            {
                int selectedCategorieID = Convert.ToInt32(cbCategorie.SelectedValue);

                if (selectedCategorieID == 37)
                {
                    LoadSubcategorii(selectedCategorieID);
                    cbSubcategorie.Visible = true;
                    labelsubcategorie.Visible = true;
                }
                else
                {
                    cbSubcategorie.Visible = false;
                    labelsubcategorie.Visible = false;
                }
            }
        }


        private void LoadSubcategorii(int categorieID)
        {
            string qry = "SELECT subcategorieID AS id, subcategorieNume AS name FROM subcategorii WHERE categorieID = " + categorieID;
            MainClass.CBFill(qry, cbSubcategorie);
        }


    }
}

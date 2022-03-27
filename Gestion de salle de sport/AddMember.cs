using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace Gestion_de_salle_de_sport
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        private void button_choosePhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Photo.ShowDialog() == DialogResult.OK)
            {
                string extention = Path.GetExtension(openFileDialog_Photo.FileName);
                string name = DateTime.Now.ToString().Replace(" ", "").Replace("/", "").Replace(":", "");
                Random rnd = new Random();
                name = name + rnd.Next() + extention;
                File.Copy(openFileDialog_Photo.FileName, "photo/" + name);
                //image_produitTextBox.Text = name;
            }
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            if(Member.roleFormMember== "Modify")
            {
                dr = db.remplir("select * from membre where idmembre=" + Member.id);
                MessageBox.Show(Member.id);
                iconButtonAddNewMember.Visible = false;
                while (dr.Read())
                {
                    txtFName.Text = dr["nom_membre"].ToString();
                    txtLName.Text = "prenom_membre";
                    txtEmail.Text = "email_membre";
                    txtPhone.Text = "tel_membre";
                    txtHealth.Text = "Health_statue";
                    txtHeight.Text = "Height";
                    txtWeight.Text = "Weight";
                    txtFat.Text = "Fat";
                    Bitmap img = new Bitmap(dr["photo"].ToString());
                    pictureBox1.BackgroundImage = img;

                }
                
            }
            if (Member.roleFormMember == "Add")
            {
                iconButtonModifyMember.Visible = false;
            }
        }
    }
}

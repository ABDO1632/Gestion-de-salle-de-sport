using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Gestion_de_salle_de_sport
{
    public partial class AddNewEquipment : Form
    {
        public AddNewEquipment()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        private void AddNewEquipment_Load(object sender, System.EventArgs e)
        {
            if (Member.roleFormMember == "Modify")
            {
                dr = db.remplir("select * from dbo.equipement where id_equipement=" + Equipment.idEquipment);

                iconButtonAddEquipment.Visible = false;
                while (dr.Read())
                {
                    txtName.Text = dr["nom_equipement"].ToString();
                    txtMusclTarger.Text = dr["muscl_target"].ToString();
                    txtState.Text = dr["etat"].ToString();
                    txtPrice.Text = dr["prix"].ToString();
                    txtQte.Text = dr["quantity"].ToString();
                    Bitmap img = new Bitmap("photo/" + dr["photo"].ToString());
                    pictureBox1.BackgroundImage = img;
                    imageTextBox.Text = dr["photo"].ToString();

                }
                db.close(dr);
            }
            if (Member.roleFormMember == "Add")
            {
                iconButtonModifyEquipment.Visible = false;
            }
        }

        private void iconButtonModifyEquipment_Click(object sender, EventArgs e)
        {
            db.Excute("update equipement set nom_equipement='" + txtName.Text + "',muscl_target='" + txtMusclTarger.Text + "',etat='" + txtState.Text + "',prix='" + txtPrice.Text + "',quantity='" + txtQte.Text + "',photo='" + imageTextBox.Text + "' where id_equipement = '" + Equipment.idEquipment + "'");

        }

        private void iconButtonAddEquipment_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtMusclTarger.Text == "" || txtState.Text == "" || imageTextBox.Text == "" || txtPrice.Text == "" || txtQte.Text == "")
            {
                MessageBox.Show("Please Insert all the Informations !!!");
            }
            else
            {
                db.Excute("insert into equipement values('" + txtName.Text + "','" + txtMusclTarger.Text + "','" + txtState.Text + "','" + imageTextBox.Text + "','" + txtPrice.Text + "','" + Form1.idSalle + "')");

            }
        }

        private void button_choosePhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Photo.ShowDialog() == DialogResult.OK)
            {
                string extention = Path.GetExtension(openFileDialog_Photo.FileName);
                string name = DateTime.Now.ToString().Replace(" ", "").Replace("/", "").Replace(":", "");
                Random rnd = new Random();
                name = name + rnd.Next() + extention;
                File.Copy(openFileDialog_Photo.FileName, "photo/" + name);
                imageTextBox.Text = name;
            }
        }
    }
}

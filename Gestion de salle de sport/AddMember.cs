using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
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
                imageTextBox.Text = name;
                Bitmap img = new Bitmap("photo/" + name);
                pictureBox1.BackgroundImage = img;
            }
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            if (Member.roleFormMember == "Modify")
            {

                dr = db.remplir("select * from membre where idmembre=" + Member.id);
                iconButtonAddNewMember.Visible = false;
                while (dr.Read())
                {
                    txtFName.Text = dr["nom_membre"].ToString();
                    txtLName.Text = dr["prenom_membre"].ToString();
                    txtEmail.Text = dr["email_membre"].ToString();
                    txtPhone.Text = dr["tel_membre"].ToString();
                    txtHealth.Text = dr["Health_statue"].ToString();
                    txtHeight.Text = dr["Height"].ToString();
                    txtWeight.Text = dr["Weight"].ToString();
                    DatepickerDateN.Value = DateTime.Parse(dr["date_naiss"].ToString());
                    txtFat.Text = dr["Fat"].ToString();
                    Bitmap img = new Bitmap("photo/" + dr["photo"].ToString());
                    pictureBox1.BackgroundImage = img;
                    imageTextBox.Text = dr["photo"].ToString();
                    comboBox1.SelectedItem = dr["gendre"].ToString();
                }
                db.close(dr);
            }
            if (Member.roleFormMember == "Add")
            {
                iconButtonModifyMember.Visible = false;
            }
        }

        private void iconButtonModifyMember_Click(object sender, EventArgs e)
        {


            db.Excute("update membre set nom_membre='" + txtFName.Text + "',prenom_membre='" + txtLName.Text + "',tel_membre='" + txtPhone.Text + "',email_membre='" + txtEmail.Text + "',date_naiss='" + DatepickerDateN.Value.ToString() + "',photo='" + imageTextBox.Text + "',Health_statue='" + txtHealth.Text + "',Height='" + txtHeight.Text.Replace(",", ".") + "',Weight='" + txtWeight.Text.Replace(",", ".") + "',fat='" + txtFat.Text.Replace(",", ".") + "',gendre='" + comboBox1.SelectedItem.ToString() + "' where idmembre = '" + Member.id + "'");

        }

        private void iconButtonAddNewMember_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtLName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || imageTextBox.Text == "" || txtHealth.Text == "" || txtHeight.Text == "" || txtWeight.Text == "" || txtFat.Text == "" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Insert all the Informations !!!");
            }
            else
            {
                db.Excute("insert into membre values('" + txtFName.Text + "','" + txtLName.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + DatepickerDateN.Value.ToString() + "','" + imageTextBox.Text + "','" + txtHealth.Text + "','" + txtHeight.Text.Replace(",", ".") + "','" + txtWeight.Text.Replace(",", ".") + "','" + txtFat.Text.Replace(",", ".") + "','" + comboBox1.SelectedItem.ToString() + "')");

            }

        }
    }
}

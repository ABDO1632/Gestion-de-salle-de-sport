using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Gestion_de_salle_de_sport
{
    public partial class AddNewFood : Form
    {
        public AddNewFood()
        {
            InitializeComponent();
        }

        private void iconButtonAddfood_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "" || imageTextBox.Text == "" || txtPrice.Text == "" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Insert all the Informations !!!");
            }
            else
            {
                db.Excute("insert into food values('" + txtName.Text + "'," + txtPrice.Text + ",'" + imageTextBox.Text + "','" + comboBox1.SelectedItem.ToString() + "')");

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
                Bitmap img = new Bitmap("photo/" + name);
                pictureBox1.BackgroundImage = img;
            }
        }
        SqlDataReader dr;
        private void AddNewFood_Load(object sender, EventArgs e)
        {
            if (Member.roleFormMember == "Modify")
            {
                iconButtonAddfood.Visible = false;

                dr = db.remplir("select * from food");
                DataTable t = new DataTable();
                DataColumn id_food = new DataColumn("id_food", typeof(int));
                DataColumn name_food = new DataColumn("name_food", typeof(string));
                t.Columns.Add(id_food);
                t.Columns.Add(name_food);
                while (dr.Read())
                {
                    DataRow r = t.NewRow();
                    r[0] = dr["id_food"];
                    r[1] = dr["name_food"];
                    t.Rows.Add(r);
                }
                comboBoxFoods.DisplayMember = "name_food";
                comboBoxFoods.ValueMember = "id_food";
                comboBoxFoods.DataSource = t;
                ///
                db.close(dr);
            }
            if(Member.roleFormMember == "Add")
            {
                iconButtonModifyFood.Visible = false;
                comboBoxFoods.Visible = false; 
                label1.Visible = false;
            }
        }

        private void iconButtonModifyFood_Click(object sender, EventArgs e)
        {


            db.Excute("update food set name_food='" + txtName.Text + "',prix='" + txtPrice.Text + "',photo='" + imageTextBox.Text + "',categorie='" + comboBox1.SelectedItem.ToString()  + "' where id_food = '" + comboBoxFoods.SelectedItem.ToString() + "'");

        }
    }
}

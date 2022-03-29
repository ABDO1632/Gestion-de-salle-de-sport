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
                    Bitmap img = new Bitmap(dr["photo"].ToString());
                    pictureBox1.BackgroundImage = img;

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

        }

        private void iconButtonAddEquipment_Click(object sender, EventArgs e)
        {

        }

        private void button_choosePhoto_Click(object sender, EventArgs e)
        {

        }
    }
}

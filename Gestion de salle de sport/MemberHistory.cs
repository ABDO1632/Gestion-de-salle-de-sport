using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Gestion_de_salle_de_sport
{
    public partial class MemberHistory : Form
    {
        public MemberHistory()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        SqlCommand com = new SqlCommand();
        private void MemberHistory_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(db.ExcuteScalare("select COUNT(*) from abonnee where idmembre=1"));
            int nb = int.Parse(db.ExcuteScalare("select COUNT(*) from abonnee where idmembre='" + Member.id + "'"));
            if (nb == 0)
            {
                dr = db.remplir("select *,DATEDIFF(Year,date_naiss,GetDate()) as Age from membre  where idmembre=" + Member.id);
                while (dr.Read())
                {
                    Bitmap img = new Bitmap("photo/" + dr["photo"].ToString());
                    pictureBox1.BackgroundImage = img;
                    idmembreTextBox.Text = dr["idmembre"].ToString();
                    nom_membreTextBox.Text = dr["nom_membre"].ToString();
                    prenom_membreTextBox.Text = dr["prenom_membre"].ToString();
                    tel_membreTextBox.Text = dr["tel_membre"].ToString();
                    email_membreTextBox.Text = dr["email_membre"].ToString();
                    //date_naissDateTimePicker.Value = DateTime.Parse(dr["date_naiss"].ToString());;
                    textBox_Age.Text = dr["Age"].ToString();
                    health_statueTextBox.Text = dr["Health_statue"].ToString();
                    heightTextBox.Text = dr["Height"].ToString();
                    weightTextBox.Text = dr["Weight"].ToString();
                    fatTextBox.Text = dr["Fat"].ToString();
                }

                db.close(dr);
            }
            else
            {
                dr = db.remplir("select *,DATEDIFF(Year,date_naiss,GetDate()) as Age from membre m inner join abonnee a on m.idmembre=a.idmembre inner join type_abonnement t on t.id_abonnement=a.id_abonnement inner join type_sport ts on ts.id_sport=t.id_sport where m.idmembre=" + Member.id);
                while (dr.Read())
                {
                    Bitmap img = new Bitmap("photo/" + dr["photo"].ToString());
                    pictureBox1.BackgroundImage = img;

                    dataGridView1.Rows.Add(dr["nom_sport"].ToString(), dr["description"].ToString(), dr["tarif_abonnement"].ToString(), dr["date_debut"].ToString(), dr["date_fin"].ToString());
                    idmembreTextBox.Text = dr["idmembre"].ToString();
                    nom_membreTextBox.Text = dr["nom_membre"].ToString();
                    prenom_membreTextBox.Text = dr["prenom_membre"].ToString();
                    tel_membreTextBox.Text = dr["tel_membre"].ToString();
                    email_membreTextBox.Text = dr["email_membre"].ToString();
                    //date_naissDateTimePicker.Value = DateTime.Parse(dr["date_naiss"].ToString());;
                    textBox_Age.Text = dr["Age"].ToString();
                    health_statueTextBox.Text = dr["Health_statue"].ToString();
                    heightTextBox.Text = dr["Height"].ToString();
                    weightTextBox.Text = dr["Weight"].ToString();
                    fatTextBox.Text = dr["Fat"].ToString();
                }

                db.close(dr);
            }

        }


    }
}

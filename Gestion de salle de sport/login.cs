using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_de_salle_de_sport
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["Gestion_de_salle_de_sport"].ConnectionString.ToString();

            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            string sql = "select * from utilisateur where username = '" + txtlogin.Text + "'";
            SqlCommand com = new SqlCommand(sql, cn);
            SqlDataReader dr = com.ExecuteReader();
            bool passport = false;
            if (dr.Read())
                if (dr["password"].ToString() == txtpassword.Text)
                {
                    passport = true;


                }



            dr.Close();
            dr = null;
            com = null;
            cn.Close();
            cn = null;
            if (passport)
            {
                txtlogin.Text = "";
                txtpassword.Text = "";
                /* this.Hide();
                 Form1 f = new Form1();
                 f.ShowDialog();
                 this.Show();*/
                Form1 f1 = new Form1();

                f1.ShowDialog();


            }
            else
                MessageBox.Show("login ou mot de passe incorrect");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

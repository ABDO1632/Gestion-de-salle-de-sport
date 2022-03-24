using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Gestion_de_salle_de_sport
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        SqlCommand com = new SqlCommand();
        private void Member_Load(object sender, EventArgs e)
        {
            dr = db.remplir("select idmembre, nom_membre, prenom_membre, tel_membre, email_membre, photo from membre");

            //DataTable t = new DataTable();
            //t.Load(dr);
           // dataGridView1.DataSource = t;
            //dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                // double p = (Convert.ToDouble(reader2["nombre_heure"]) * 100) / Convert.ToDouble(lblNbHeure.Text);
                Bitmap img = new Bitmap(dr["photo"].ToString());
                Button b = ButtonDelete;
                dataGridView1.Rows.Add(dr["idmembre"].ToString(), dr["nom_membre"].ToString(), dr["prenom_membre"].ToString(), dr["tel_membre"].ToString(), dr["email_membre"].ToString(), img, ButtonDelete);

            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MSG!!!!205, 37, 74");
        }
    }
}

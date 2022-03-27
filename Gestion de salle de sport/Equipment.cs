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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        SqlCommand com = new SqlCommand();
        private void ButtonAddNewEquipment_Click(object sender, EventArgs e)
        {
            Form1.ClickedE();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            dr = db.remplir("select id_equipement,photo, nom_equipement, muscl_target, etat, prix,quantity from equipement");

            //DataTable t = new DataTable();
            //t.Load(dr);
            // dataGridView1.DataSource = t;
            //dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                Bitmap img = new Bitmap(dr["photo"].ToString());


                Button b = new Button();
                dataGridView1.Rows.Add(dr["id_equipement"].ToString(), img, dr["nom_equipement"].ToString(), dr["muscl_target"].ToString(), dr["etat"].ToString(), dr["prix"].ToString(), dr["quantity"].ToString(), b); ;

            }
        }
    }
}

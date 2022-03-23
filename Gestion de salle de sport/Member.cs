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
            dr = db.remplir("select * from membre");

            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView1.DataSource = t;
        }
    }
}

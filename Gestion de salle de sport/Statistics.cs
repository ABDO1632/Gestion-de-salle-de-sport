using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_de_salle_de_sport
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        string cs = ConfigurationManager.ConnectionStrings["Gestion_de_salle_de_sport"].ConnectionString.ToString();

        private void Statistics_Load(object sender, System.EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
            /////////////////////////////////////////Membres////////////////////////////////////////////////
            cn = new SqlConnection(cs);
            cn.Open();

            SqlCommand com;

            com = new SqlCommand("select count(*) as nombre from membre m inner join abonnee a on a.idmembre=m.idmembre where MONTH(a.date_debut) = MONTH(GETDATE()) and YEAR(a.date_debut) = YEAR(GETDATE())", cn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lblmembres.Text = dr["nombre"].ToString();
            }
            dr.Close();
            dr = null;
            com = null;

            ///////////////////////////////coachs//////////////////////////////////////////////////////////////
            ///


            SqlCommand com1;
            com1 = new SqlCommand("select count (*) as nombre from coach", cn);
            SqlDataReader dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                lblcoachs.Text = dr1["nombre"].ToString();
            }
            dr1.Close();
            dr1 = null;
            com1 = null;

            ///////////////////////////equipements ////////////////////////////////////////////////////////////////
            ///


            SqlCommand com2;
            com2 = new SqlCommand("select count(*) as nombre from equipement", cn);
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                lblequipements.Text = dr2["nombre"].ToString();
            }
            dr2.Close();
            dr2 = null;
            com2 = null;

            ////////////////////////////////////////purvhases //////////////////////////////////////
            ///
            SqlCommand com3;
            com3 = new SqlCommand("select sum(prix) as prix  from equipement", cn);
            SqlDataReader dr3 = com3.ExecuteReader();
            while (dr3.Read())
            {
                lblpurchases.Text = Math.Round(Convert.ToDouble(dr3["prix"]), 2).ToString();
            }
            dr3.Close();
            dr3 = null;
            com3 = null;

            /////////////////////////////////////////cash////////////////////////////////
            ///

            SqlCommand com4;
            com4 = new SqlCommand("select sum(tarif_abonnement) as tarif from type_abonnement t inner join abonnee a on t.id_abonnement = a.id_abonnement where MONTH(date_debut) = MONTH(GETDATE()) and YEAR(date_debut) = YEAR(GETDATE())", cn);
            SqlDataReader dr4 = com4.ExecuteReader();
            while (dr4.Read())
            {
                lblcash.Text = Math.Round(Convert.ToDouble(dr4["tarif"]), 2).ToString();
            }
            dr4.Close();
            dr4 = null;
            com4 = null;




            //////////////////////////chart //////////////////////////////////////////////
            ///
            chart1.Series.Add(membrs.Text);
            chart1.Series.Add(coachs.Text);
            chart1.Series.Add(equipement.Text);
            // chart1.Series.Add(purchases.Text);
            // chart1.Series.Add(cash.Text);
            chart1.Series[membrs.Text].Points.AddXY(membrs.Text, Convert.ToDouble(lblmembres.Text));
            chart1.Series[coachs.Text].Points.AddXY(coachs.Text, Convert.ToDouble(lblcoachs.Text));
            chart1.Series[equipement.Text].Points.AddXY(equipement.Text, Convert.ToDouble(lblequipements.Text));
            //chart1.Series[purchases.Text].Points.AddXY(purchases.Text,Convert.ToDouble( lblpurchases.Text));
            // chart1.Series[cash.Text].Points.AddXY(cash.Text,Convert.ToDouble( lblcash.Text));




            /////////////////////membres years/////////////////////////
            ///
            SqlCommand com5;

            com5 = new SqlCommand("select count(*) as nombre from membre m inner join abonnee a on a.idmembre=m.idmembre where  YEAR(a.date_debut) = YEAR(GETDATE())", cn);
            SqlDataReader dr5 = com5.ExecuteReader();
            while (dr5.Read())
            {
                lblMembrsY.Text = dr5["nombre"].ToString();
            }
            dr5.Close();
            dr5 = null;
            com5 = null;


            /////////////////////////////////////////cash////////////////////////////////
            ///

            SqlCommand com6;
            com6 = new SqlCommand("select sum(tarif_abonnement) as tarif from type_abonnement t inner join abonnee a on t.id_abonnement = a.id_abonnement where  YEAR(date_debut) = YEAR(GETDATE())", cn);
            SqlDataReader dr6 = com6.ExecuteReader();
            while (dr6.Read())
            {
                lblcashY.Text = Math.Round(Convert.ToDouble(dr6["tarif"]), 2).ToString() + " DH";
            }
            dr6.Close();
            dr6 = null;
            com6 = null;
            cn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}

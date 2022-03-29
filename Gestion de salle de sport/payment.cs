using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace Gestion_de_salle_de_sport
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection();
        DataSet ds = new DataSet();
        SqlCommand com;
        SqlDataAdapter da;
        BindingSource bs = new BindingSource();
        SqlCommandBuilder cb = new SqlCommandBuilder();
        drscriptionabonnement d1 = new drscriptionabonnement("1 mounth", "normal");
        drscriptionabonnement d2 = new drscriptionabonnement("3 mounth", "+15 days free");
        drscriptionabonnement d3 = new drscriptionabonnement("6 mounth", "1 mounth free");
        drscriptionabonnement d4 = new drscriptionabonnement("12 mounth", "1 mounth 15 days free");
        private void payment_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["Gestion_de_salle_de_sport"].ConnectionString.ToString();
            cn.ConnectionString = cs;
            cn.Open();
            com = new SqlCommand("select a.idmembre,a.id_abonnement,nom_membre,prenom_membre,a.date_debut,a.date_fin,t.tarif_abonnement ,t.libelle_abonnement,t.description  from membre m inner join abonnee a on m.idmembre = a.idmembre inner join type_abonnement t on t.id_abonnement = a.id_abonnement order by nom_membre ", cn);
            da = new SqlDataAdapter(com);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "abonnee");
            bs.DataSource = ds;
            bs.DataMember = "abonnee";
            dt1.DataSource = bs;
            txtnom.DataBindings.Add("Text", bs, "nom_membre");
            txtprenom.DataBindings.Add("Text", bs, "prenom_membre");
            txtabonnemnt.DataBindings.Add("Text", bs, "tarif_abonnement");
            txtdatedebut.DataBindings.Add("Text", bs, "date_debut");
            txtdatefin.DataBindings.Add("Text", bs, "date_fin");
            idmembre.DataBindings.Add("Text", bs, "idmembre");
            idabonnement.DataBindings.Add("Text", bs, "id_abonnement");
            btnvalidate.Visible = false;
            btncancel.Visible = false;
            panel1.Enabled = false;

            comboBox1.Items.Add(d1.Libelle_abonnement);
            comboBox1.Items.Add(d2.Libelle_abonnement);
            comboBox1.Items.Add(d3.Libelle_abonnement);
            comboBox1.Items.Add(d4.Libelle_abonnement);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = false;
            txtnom.Enabled = false;
            txtprenom.Enabled = false;
            idmembre.Enabled = false;
            idabonnement.Enabled = false;
            panel1.Enabled = true;
            btncancel.Visible = true;
            btnvalidate.Visible = true;
            txtdatedebut.Enabled = false;
            txtdatefin.Enabled = false;
            datedebbut.Visible = true;
            datefin.Visible = true;
            panel2.Visible = true;
        }
        bool passe = true;
        private void btnvalidate_Click(object sender, EventArgs e)
        {
            passe = true;
            if (idmembre.Text == string.Empty)
            {
                idmembre.LineIdleColor = Color.Red;
                idmembre.HintText = "You must fill in this field";
                idmembre.HintForeColor = Color.Red;
                passe = false;
            }
            if (idabonnement.Text == string.Empty)
            {
                idabonnement.LineIdleColor = Color.Red;
                idabonnement.HintText = "You must fill in this field";
                idabonnement.HintForeColor = Color.Red;
                passe = false;
            }
            if (txtnom.Text == string.Empty)/// || txtprenom.Text == string.Empty || txtdatedebut.Text == string.Empty || txtdatefin.Text == string.Empty || txtabonnemnt.Text == string.Empty)
            {
                txtnom.LineIdleColor = Color.Red;
                txtnom.HintText = "You must fill in this field";
                txtnom.HintForeColor = Color.Red;
                passe = false;
            }
            if (txtprenom.Text == string.Empty)
            {
                txtprenom.LineIdleColor = Color.Red;
                txtprenom.HintText = "You must fill in this field";
                txtprenom.HintForeColor = Color.Red;
                passe = false;
            }
            if (txtdatedebut.Text == string.Empty)
            {
                datedebbut.ForeColor = Color.Red;
                txtdatedebut.LineIdleColor = Color.Red;
                txtdatedebut.HintText = "You must fill in this field";
                txtdatedebut.HintForeColor = Color.Red;
                passe = false;

            }
            if (txtdatefin.Text == string.Empty)
            {
                datefin.ForeColor = Color.Red;
                txtdatefin.LineIdleColor = Color.Red;
                txtdatefin.HintText = "You must fill in this field";
                txtdatefin.HintForeColor = Color.Red;
                passe = false;

            }
            if (txtabonnemnt.Text == string.Empty)
            {
                txtabonnemnt.LineIdleColor = Color.Red;
                txtabonnemnt.HintText = "You must fill in this field";
                txtabonnemnt.HintForeColor = Color.Red;
                passe = false;
            }
            if (passe)
            {
                txtnom.LineIdleColor = Color.Gray;
                txtnom.HintText = "";
                txtprenom.LineIdleColor = Color.Gray;
                txtprenom.HintText = "";
                datedebbut.ForeColor = Color.Gray;
                datefin.ForeColor = Color.Gray;
                txtabonnemnt.LineIdleColor = Color.Gray;
                txtabonnemnt.HintText = "";
                txtdatedebut.LineIdleColor = Color.Gray;
                txtdatedebut.HintText = "";
                txtdatefin.LineIdleColor = Color.Gray;
                txtdatefin.HintText = "";
                idmembre.LineIdleColor = Color.Gray;
                idmembre.HintText = "";
                idmembre.HintForeColor = Color.Black;
                idabonnement.LineIdleColor = Color.Gray;
                idabonnement.HintText = "";
                idabonnement.HintForeColor = Color.Black;
                if (MessageBox.Show("do you really register this payment?", "message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    SqlCommand com1 = new SqlCommand("insert into abonnee values ( @idmembre, @idabonnement, @datedebut,@datefin )", cn);

                    com1.Parameters.AddWithValue("@idmembre", idmembre.Text);
                    com1.Parameters.AddWithValue("@idabonnement", idabonnement.Text);
                    com1.Parameters.AddWithValue("@datedebut", txtdatedebut.Text);
                    com1.Parameters.AddWithValue("@datefin", txtdatefin.Text);
                    com1.ExecuteNonQuery();
                    da.Update(ds.Tables["abonnee"]);
                    com1 = null;
                    
                    btnvalidate.Visible = false;
                    btnadd.Enabled = true;
                    btncancel.Visible = true;
                    txtdatedebut.Enabled = true;
                    txtdatefin.Enabled = true;
                    datedebbut.Visible = false;
                    datefin.Visible = false;
                    panel1.Enabled = false;
                    btncancel.Visible = false;
                    panel2.Visible = false;

                }
                passe = true;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            btnvalidate.Visible = false;
            btnadd.Enabled = true;
            btncancel.Visible = false;
            txtdatedebut.Enabled = true;
            txtdatefin.Enabled = true;
            datedebbut.Visible = false;
            datefin.Visible = false;
            panel1.Enabled = false;
            txtnom.LineIdleColor = Color.Gray;
            txtnom.HintText = "";
            txtnom.HintForeColor = Color.Black;
            txtprenom.LineIdleColor = Color.Gray;
            txtprenom.HintText = "";
            txtprenom.HintForeColor = Color.Black;
            datedebbut.ForeColor = Color.Gray;
            datefin.ForeColor = Color.Gray;
            txtabonnemnt.LineIdleColor = Color.Gray;
            txtabonnemnt.HintText = "";
            txtabonnemnt.HintForeColor = Color.Black;
            txtdatedebut.LineIdleColor = Color.Gray;
            txtdatedebut.HintText = "";
            txtdatedebut.HintForeColor = Color.Black;
            txtdatefin.LineIdleColor = Color.Gray;
            txtdatefin.HintText = "";
            txtdatefin.HintForeColor = Color.Black;
            idmembre.LineIdleColor = Color.Gray;
            idmembre.HintText = "";
            idmembre.HintForeColor = Color.Black;
            idabonnement.LineIdleColor = Color.Gray;
            idabonnement.HintText = "";
            idabonnement.HintForeColor = Color.Black;
            passe = true;
            txtnom.Enabled = false;
            txtprenom.Enabled = false;
            idmembre.Enabled = false;
            idabonnement.Enabled = false;
            panel2.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bs.Filter = "nom_membre like '%" + txtchercher.Text + "%' or prenom_membre like '%" + txtchercher.Text + "%'";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == d1.Libelle_abonnement)
            {
                txtdesc.Text = d1.Description;
            }
            if (comboBox1.Text == d2.Libelle_abonnement)
            {
                txtdesc.Text = d2.Description;
            }
            if (comboBox1.Text == d3.Libelle_abonnement)
            {
                txtdesc.Text = d3.Description;
            }
            if (comboBox1.Text == d4.Libelle_abonnement)
            {
                txtdesc.Text = d4.Description;
            }
        }

     
    }
}

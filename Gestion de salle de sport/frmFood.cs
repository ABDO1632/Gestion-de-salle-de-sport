using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
namespace Gestion_de_salle_de_sport
{
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }
        public static void CloneControl(Control SourceControl, Control DestinationControl)
        {
            String[] PropertiesToClone = new String[] { "Size", "Font", "Text", "Tag", "Dock", "BackColor", "ForeColor", "BorderStyle", "TextAlign", "Width", "Margin" };
            PropertyInfo[] controlProperties = SourceControl.GetType().GetProperties();

            foreach (String Property in PropertiesToClone)
            {
                PropertyInfo ObjPropertyInfo = controlProperties.First(a => a.Name == Property);
                ObjPropertyInfo.SetValue(DestinationControl, ObjPropertyInfo.GetValue(SourceControl, null), null);
            }
        }
        public Panel duplicatePanel(Panel panel1)
        {

            // uxMsgTxt.Text += “Adding Panel ” +i.ToString() + “rn”;
            Panel pnl = new Panel();
            //pnl.Location = new Point(10 * i, 10 * i);
            pnl.BorderStyle = panel1.BorderStyle;
            pnl.BackColor = panel1.BackColor;
            pnl.Size = panel1.Size;
            pnl.Dock = DockStyle.Fill;
            pnl.Visible = true;



            foreach (Control c in panel1.Controls)
            {
                // MessageBox.Show(c.GetType().ToString());
                Control c2 = new Control();

                if (c.GetType() == typeof(TextBox))
                {
                    c2 = new TextBox();

                    //c2.Location = c.Location;
                    //c2.Size = c.Size;
                    //c2.Text = c.Text;
                    //c2.Dock = c.Dock;
                    CloneControl(c, c2);
                    pnl.Controls.Add(c2);
                }

                if (c.GetType() == typeof(PictureBox))
                {
                    c2 = new PictureBox();


                    c2.Location = c.Location;
                    c2.Size = c.Size;
                    if (c2.Name == "pic_chicken")
                    {
                        c2.Click += pic_chicken_Click;
                    }

                    c2.Text = c.Text;
                    c2.Dock = c.Dock;
                    c2.BackgroundImage = c.BackgroundImage;
                    c2.BackgroundImageLayout = c.BackgroundImageLayout;

                    pnl.Controls.Add(c2);

                }
                if (c.GetType() == typeof(Label))
                {
                    c2 = new Label();

                    c2.Location = c.Location;
                    c2.Size = c.Size;
                    c2.Text = c.Text;

                    if (c.Text == "Add")
                    {
                        c2.Click += lblAdd_Click;
                        c2.Cursor = Cursors.Hand;
                    }
                    CloneControl(c, c2);
                    c2.Dock = c.Dock;

                    pnl.Controls.Add(c2);
                }


                if (c.GetType() == typeof(Panel))
                {
                    c2 = new Panel();
                    c2 = duplicatePanel((Panel)c);
                    pnl.Controls.Add(c2);
                }



                // tableLayoutPanel1.Controls.Add(c2);
            }

            return pnl;


        }
        public void activate(bool test)
        {
            txt_qte.Enabled = test;
            cb_member.Enabled = test;

        }
        SqlDataReader dr;
        private void frmFood_Load(object sender, EventArgs e)
        {
            dr = db.remplir("select * from membre");
            DataTable t = new DataTable();
            DataColumn idmembre = new DataColumn("idmembre", typeof(int));
            DataColumn nom_Memb = new DataColumn("nom_membre", typeof(string));
            t.Columns.Add(idmembre);
            t.Columns.Add(nom_Memb);
            while (dr.Read())
            {
                DataRow r = t.NewRow();
                r[0] = dr["idmembre"];
                r[1] = dr["nom_membre"];
                t.Rows.Add(r);
            }
            cb_member.DisplayMember = "nom_membre";
            cb_member.ValueMember = "idmembre";
            cb_member.DataSource = t;
            ///
            db.close(dr);
            pnl_note.Visible = true;


            panel2.Visible = false;
            //txt_idFood.Text = "1";
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            if ((Double.Parse(txt_qte.Text) <= 1))
            {
                MessageBox.Show("Please Enter Quanity ");
            }
            else
            {
                Label lbl = (Label)sender;
                txt_idFood.Text = lbl.Tag.ToString();
                string prixFood = db.ExcuteScalare("select prix from food where id_food='" + txt_idFood.Text + "'");
                Double d = (Double.Parse(prixFood)) * Double.Parse(txt_qte.Text);
                txt_price.Text = d.ToString();
            }

        }

        private void pic_chicken_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            MessageBox.Show(pic.Tag.ToString());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            pnl_note.Visible = false;
            tableLayoutPanel1.Controls.Clear();
            label2.Text = "food";

            dr = db.remplir("select * from food where categorie like 'food'");


            while (dr.Read())
            {
                //MessageBox.Show(dr["photo"].ToString());
                Bitmap img = new Bitmap("photo/" + dr["photo"].ToString());

                pic_chicken.BackgroundImage = img;
                labelPrice.Text = dr["prix"].ToString();
                labelTitle.Text = dr["name_food"].ToString();
                lblAdd.Tag = dr["id_food"].ToString();

                Panel pn = new Panel();
                pn = duplicatePanel(panel2);
                tableLayoutPanel1.Controls.Add(pn);


            }
            db.close(dr);
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Confirm !", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == re)
            {
                if (cb_member.SelectedIndex == -1 || int.Parse(txt_qte.Text) <= 0 || txt_idFood.Text == "")
                {

                }
                else
                {
                    db.Excute("insert into demande(idmembre,id_food,date_demande,quantite) values('" + cb_member.SelectedValue.ToString() + "','" + txt_idFood.Text + "',GetDate()," + txt_qte.Text + ")");
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }



        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            pnl_note.Visible = false;
            tableLayoutPanel1.Controls.Clear();
            label2.Text = "Drinks";
            db.Ouvreconnexion();

            dr = db.remplir("select * from food where categorie like 'drink'");


            while (dr.Read())
            {

                Bitmap img = new Bitmap("photo/" + dr["photo"].ToString());

                pic_chicken.BackgroundImage = img;
                labelPrice.Text = dr["prix"].ToString();
                labelTitle.Text = dr["name_food"].ToString();
                lblAdd.Tag = dr["id_food"].ToString();


                Panel pn = new Panel();
                pn = duplicatePanel(panel2);
                tableLayoutPanel1.Controls.Add(pn);


            }
            db.close(dr);
        }

        private void txt_qte_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void iconButtonAddNewFood_Click(object sender, EventArgs e)
        {
            AddNewFood fd = new AddNewFood();
            Member.roleFormMember = "Add";
            fd.ShowDialog();
        }

        private void iconButtonModify_Click(object sender, EventArgs e)
        {
            AddNewFood fd = new AddNewFood();
            Member.roleFormMember = "Modify";
            fd.ShowDialog();
        }
    }
}

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
            String[] PropertiesToClone = new String[] { "Size", "Font", "Text", "Tag", "Dock", "BackColor", "ForeColor", "BorderStyle", "TextAlign", "Width", "Height", "Margin" };
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

                    //   buttonOK.Size = new Size(75,25);

                    pnl.Controls.Add(c2);

                }
                if (c.GetType() == typeof(Label))
                {
                    c2 = new Label();

                    c2.Location = c.Location;
                    c2.Size = c.Size;
                    c2.Text = c.Text;

                    if (c.Text == "Add +")
                    {
                        c2.Click += lblAdd_Click;
                        c2.Cursor = Cursors.Hand;
                        c2.MouseEnter += lblAdd_MouseEnter;
                        c2.MouseLeave += lblAdd_MouseLeave;
                    }
                    CloneControl(c, c2);
                    c2.Dock = c.Dock;

                    pnl.Controls.Add(c2);
                }


                if (c.GetType() == typeof(NumericUpDown))
                {
                    c2 = new NumericUpDown();
                    c2.Location = c.Location;
                    c2.Size = c.Size;
                    //c2.Text = c.Text;
                    c2.Tag = c.Tag;

                    c2.Dock = c.Dock;
                    CloneControl(c, c2);
                    pnl.Controls.Add(c2);
                }



                // tableLayoutPanel1.Controls.Add(c2);
            }

            return pnl;


        }
        public void activate(bool test)
        {
            cb_member.Enabled = test;

        }
        SqlDataReader dr;
        private void frmFood_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("IdFood");
            dt.Columns.Add("NomFood");
            dt.Columns.Add("Quantity");
            //dt1.Columns[0].Visible = false;
            dt1.Visible = false;
            btnDeleteCommande.Visible = false;

            dr = db.remplir("select * from membre");
            DataTable t = new DataTable();
            DataColumn idmembre = new DataColumn("idmembre", typeof(int));
            DataColumn nom_Memb = new DataColumn("nom_membre" + "_" + "prenom_membre", typeof(string));
            t.Columns.Add(idmembre);
            t.Columns.Add(nom_Memb);
            while (dr.Read())
            {
                DataRow r = t.NewRow();
                r[0] = dr["idmembre"];
                r[1] = dr["nom_membre"] + "_" + dr["prenom_membre"];
                t.Rows.Add(r);
            }
            cb_member.DisplayMember = "nom_membre" + "_" + "prenom_membre";
            cb_member.ValueMember = "idmembre";
            cb_member.DataSource = t;
            ///
            db.close(dr);
            pnl_note.Visible = true;


            panel2.Visible = false;
            //txt_idFood.Text = "1";
        }
        DataTable dt = new DataTable();

        private void lblAdd_Click(object sender, EventArgs e)
        {

            Label lbl = (Label)sender;
            txt_idFood.Text = lbl.Tag.ToString();
            string NomFood = db.ExcuteScalare("select name_food from food where id_food='" + txt_idFood.Text + "'");

            
            //////
            int nb = 0;
            foreach (Control x in this.tableLayoutPanel1.Controls)
            {
                if (x is Panel)
                {
                    //((NumericUpDown)x).Text = String.Empty;
                    foreach (Control k in x.Controls)
                    {
                        if (k is NumericUpDown && k.Tag.ToString() == lbl.Tag.ToString())
                        {
                            //((NumericUpDown)x).Text = String.Empty;
                            nb = int.Parse(((NumericUpDown)k).Value.ToString());
                        }
                    }
                }
            }
            dt.Rows.Add(new object[] { lbl.Tag.ToString(), NomFood, nb });
            dt1.DataSource = dt;
            dt1.Columns["IdFood"].Visible = false;

            //////


        }

        private void pic_chicken_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            MessageBox.Show(pic.Tag.ToString());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            pnl_note.Visible = false;
            dt1.Visible = true;
            btnDeleteCommande.Visible = true;
            tableLayoutPanel1.Controls.Clear();
            label2.Text = "food";

            dr = db.remplir("select *,convert(numeric(10,2), prix) as price from food where categorie like 'food'");


            while (dr.Read())
            {
                //MessageBox.Show(dr["photo"].ToString());
                Bitmap img = new Bitmap("photo/" + dr["photo"].ToString());

                pic_chicken.BackgroundImage = img;
                labelPrice.Text = dr["price"].ToString()+" DH";
                labelTitle.Text = dr["name_food"].ToString();
                lblAdd.Tag = dr["id_food"].ToString();
                numericUpDownQte.Tag = dr["id_food"].ToString();
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
                if (cb_member.SelectedIndex == -1 ||  txt_idFood.Text == "")
                {

                }
                else
                {
                    for(int i = 0; i < dt1.Rows.Count; i++)
                    {
                        db.Excute("insert into demande(idmembre,id_food,date_demande,quantite) values('" + cb_member.SelectedValue.ToString() + "','" + dt1.Rows[i].Cells[0].Value.ToString() + "',GetDate()," + dt1.Rows[i].Cells[2].Value.ToString() + ")");

                    }
                    //dt1.Rows.Clear();
                }
            }
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
                //MessageBox.Show();
                Bitmap img = new Bitmap("photo/" + dr["photo"].ToString());

                pic_chicken.BackgroundImage = img;
                labelPrice.Text = dr["prix"].ToString();
                labelTitle.Text = dr["name_food"].ToString();
                lblAdd.Tag = dr["id_food"].ToString();
                numericUpDownQte.Tag = dr["id_food"].ToString();

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

        private void lblAdd_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.FromArgb(218, 12, 85);
        }

        private void lblAdd_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.FromArgb(110, 84, 169);
        }

        

        private void btnDeleteCommande_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row;
            int length;

            length = dt1.SelectedRows.Count;
            for (int i = length - 1; i >= 0; i--)
            {
                row = dt1.SelectedRows[i];
                dt1.Rows.Remove(row);
            }
        }
        
        private void dt1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double PriceTotal = 0;
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string prixFood = db.ExcuteScalare("select prix from food where id_food='" + dt1.Rows[i].Cells[0].Value.ToString() + "'");
                PriceTotal += double.Parse(prixFood);
            }
            txt_price.Text = PriceTotal.ToString();
        }

        private void dt1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double PriceTotal = 0;
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string prixFood = db.ExcuteScalare("select prix from food where id_food='" + dt1.Rows[i].Cells[0].Value.ToString() + "'");
                PriceTotal += double.Parse(prixFood);
            }
            txt_price.Text = PriceTotal.ToString();
        }
    }
}

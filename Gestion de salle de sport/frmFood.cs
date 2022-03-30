using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
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
            String[] PropertiesToClone = new String[] { "Size", "Font", "Text", "Tag", "BackColor", "ForeColor", "BorderStyle", "TextAlign", "Width", "Margin" };
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

                    //copyControl(c, c2);

                    c2.Location = c.Location;
                    c2.Size = c.Size;
                    c2.Text = c.Text;
                    c2.Dock = c.Dock;
                    if (c.Text == "Add")
                    {
                        c2.Click += lblAdd_Click;
                    }
                    CloneControl(c, c2);
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
            btn_buy.Enabled = test;
            btn_cancel.Enabled = test;

            btn_newFood.Enabled = !test;
            btn_archive.Enabled = !test;
        }
        SqlDataReader dr;
        private void frmFood_Load(object sender, EventArgs e)
        {
            db.Ouvreconnexion();
            txt_idFood.Visible = false;
            dr = db.remplir("select * from membre");

            while (dr.Read())
            {
                cb_member.Items.Add(dr["nom_membre"].ToString());
                cb_member.DisplayMember = dr[1].ToString();
                cb_member.ValueMember = dr[0].ToString();

            }
            db.close(dr);
            pnl_note.Visible = true;


            panel2.Visible = false;
            //txt_idFood.Text = "1";

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            txt_idFood.Text = lbl.Tag.ToString();
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
            db.Ouvreconnexion();
            dr = db.remplir("select * from food where categorie like 'food'");


            while (dr.Read())
            {
                MessageBox.Show(dr["photo"].ToString());
                Bitmap img = new Bitmap("photo" + dr["photo"].ToString());

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
    }
}

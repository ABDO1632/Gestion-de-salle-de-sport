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
               
                //DataGridViewImageCell img2 = new DataGridViewImageCell();
                //   dataGridView1.Columns.Add(new DataGridViewImageColumn()
                //    {

                //       // Text = "Say Hi",
                //       //// Tag = (Action<Person>)ClickHandler,
                //       // UseColumnTextForButtonValue = true,
                //       // AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                //       Image=img,
                //      // Cu
                //       ImageLayout=DataGridViewImageCellLayout.Zoom,

                //    });

                //Button b = ButtonDelete;
                //b.Text = "FEFE";
                // DataGridViewImageCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                Bitmap img1 = new Bitmap("delete_trash.png"); 
                Bitmap img2 = new Bitmap("modify.png");
                Bitmap img3 = new Bitmap("documents.png");
                dataGridView1.Rows.Add(dr["idmembre"].ToString(), img, dr["nom_membre"].ToString(), dr["prenom_membre"].ToString(), dr["tel_membre"].ToString(), dr["email_membre"].ToString(),img3,img2, img1);;
               // AddButton();
              
            }
        }
        public void AddButton()
        {
            //Add button
            DataGridViewButtonColumn EditButton = new DataGridViewButtonColumn();
            EditButton.UseColumnTextForButtonValue = true;
            EditButton.DataPropertyName = "btnColumn";
            EditButton.Text = "Button Text";
           // EditButton.FillWeight
            dataGridView1.Columns.Add(EditButton);
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MSG!!!!205, 37, 74");
        }

        private void ButtonAddNewMember_Click(object sender, EventArgs e)
        {
            
           // Form1 f=new Form1();
            Form1.ClickedM();
            
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NNzizia");
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show(dataGridView1.Columns[e.ColumnIndex].ToString()+"////"+dataGridView1.Rows[e.RowIndex].ToString());
           // MessageBox.Show(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
            //MessageBox.Show(e.Button.ToString());
           
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex >= 0)
                {
                    dataGridView1.Cursor = Cursors.Default;

                    if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["Delete"] && e.RowIndex >= 0 )
                    {
                        l = e.ColumnIndex.ToString();
                        // MessageBox.Show(dataGridView1.Columns["Buttons"].DefaultCellStyle.BackColor.ToString());
                        label1.Text = dataGridView1[e.ColumnIndex, e.RowIndex].ToString();

                        //MessageBox.Show(dataGridView1[e.ColumnIndex, e.RowIndex].Tag.ToString());
                        dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Empty;

                        // dataGridView1.Columns["Buttons"].DefaultCellStyle.BackColor = Color.FromArgb(205, 37, 74);
                        //MessageBox.Show(dataGridView1.Rows[e.RowIndex].ToString());
                    }
                    if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["Modify"] && e.RowIndex >= 0)
                    {
                        label1.Text = dataGridView1[e.ColumnIndex, e.RowIndex].ToString();

                        dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Empty;

                        // dataGridView1.Columns["Buttons"].DefaultCellStyle.BackColor = Color.FromArgb(205, 37, 74);
                        //MessageBox.Show(dataGridView1.Rows[e.RowIndex].ToString());
                    }
                    if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["CheckHistory"] && e.RowIndex >= 0)
                    {
                        label1.Text = dataGridView1[e.ColumnIndex, e.RowIndex].ToString();
                        dataGridView1.Cursor = Cursors.Hand;
                        dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Empty;

                    }
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " Leave");
            }
            // dataGridView1.Cursor = Cursors.Default;
        }
        string c = "x";
        string l = "p";
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {

                    if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["Delete"] && e.RowIndex >= 0 && e.RowIndex >= 0)
                    {
                        dataGridView1.Cursor = Cursors.Hand;

                        c = e.ColumnIndex.ToString();

                        // MessageBox.Show(dataGridView1.Columns["Buttons"].DefaultCellStyle.BackColor.ToString());
                        label1.Text = dataGridView1[e.ColumnIndex, e.RowIndex].ToString();

                        //MessageBox.Show(dataGridView1[e.ColumnIndex, e.RowIndex].Tag.ToString());
                        dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(205, 37, 74);

                        // dataGridView1.Columns["Buttons"].DefaultCellStyle.BackColor = Color.FromArgb(205, 37, 74);
                        //MessageBox.Show(dataGridView1.Rows[e.RowIndex].ToString());
                    }
                    if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["Modify"] && e.RowIndex >= 0)
                    {
                        label1.Text = dataGridView1[e.ColumnIndex, e.RowIndex].ToString();
                        dataGridView1.Cursor = Cursors.Hand;
                        dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(205, 37, 74);

                    }
                    if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["CheckHistory"] && e.RowIndex >= 0)
                    {
                        label1.Text = dataGridView1[e.ColumnIndex, e.RowIndex].ToString();
                        dataGridView1.Cursor = Cursors.Hand;
                        dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(205, 37, 74);

                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()+"/// Enter // l="+l) ;
            }
               // dataGridView1.Cursor = Cursors.Default;
        }
    }
}

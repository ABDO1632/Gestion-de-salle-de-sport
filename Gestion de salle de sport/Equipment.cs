using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
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
            Member.roleFormMember = "Add";
            Form1.ClickedE();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            dr = db.remplir("select id_equipement,photo, nom_equipement, muscl_target, etat, prix,quantity from equipement");

            while (dr.Read())
            {

                //MessageBox.Show(dr["photo"].ToString());
                Bitmap img = new Bitmap("./photo/" + dr["photo"].ToString());
                Bitmap img1 = new Bitmap("photo/" + "delete_trash.png");
                Bitmap img2 = new Bitmap("photo/" + "modify.png");
                dataGridView1.Rows.Add(dr["id_equipement"].ToString(), img, dr["nom_equipement"].ToString(), dr["muscl_target"].ToString(), dr["etat"].ToString(), dr["prix"].ToString(), dr["quantity"].ToString(), img2, img1); ;

            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {

                    if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["Delete"] && e.RowIndex >= 0 && e.RowIndex >= 0)
                    {
                        dataGridView1.Cursor = Cursors.Hand;
                        dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(205, 37, 74);

                    }
                    if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["Modify"] && e.RowIndex >= 0)
                    {
                        dataGridView1.Cursor = Cursors.Hand;
                        dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(205, 37, 74);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    dataGridView1.Cursor = Cursors.Default;

                    if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["Delete"] && e.RowIndex >= 0)
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Empty;
                    }
                    if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["Modify"] && e.RowIndex >= 0)
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Empty;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " Leave");
            }
        }
        public static string idEquipment = "1";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {

                if (senderGrid.Columns[e.ColumnIndex] == dataGridView1.Columns["Modify"])
                {
                    idEquipment = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Member.roleFormMember = "Modify";
                    AddNewEquipment ad = new AddNewEquipment();
                    ad.ShowDialog();
                }
                if (senderGrid.Columns[e.ColumnIndex] == dataGridView1.Columns["Delete"])
                {
                    idEquipment = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    MessageBox.Show(" Delete!!!!");
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dr = db.remplir("select id_equipement,photo, nom_equipement, muscl_target, etat, prix,quantity from equipement where nom_equipement like '%" + txtNameEquipment.Text + "%'");
            if (dataGridView1.Rows.Count >= 1)
            {
                dataGridView1.Rows.Clear();
            }
            while (dr.Read())
            {
                Bitmap img = new Bitmap("photo/" + dr["photo"].ToString());
                Bitmap img1 = new Bitmap("photo/" + "delete_trash.png");
                Bitmap img2 = new Bitmap("photo/" + "modify.png");
                Bitmap img3 = new Bitmap("photo/" + "documents.png");
                dataGridView1.Rows.Add(dr["id_equipement"].ToString(), img, dr["nom_equipement"].ToString(), dr["muscl_target"].ToString(), dr["etat"].ToString(), dr["prix"].ToString(), dr["quantity"].ToString(), img2, img1); ;
            }
        }
    }
}

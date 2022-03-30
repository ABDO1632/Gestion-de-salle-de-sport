using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Gestion_de_salle_de_sport
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        public void remplirMembers()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();

            }
            dr = db.remplir("select idmembre, nom_membre, prenom_membre, tel_membre, email_membre, photo from membre");
            while (dr.Read())
            {
                Bitmap img = new Bitmap("photo/" + dr["photo"].ToString());
                Bitmap img1 = new Bitmap("photo/" + "delete_trash.png");
                Bitmap img2 = new Bitmap("photo/" + "modify.png");
                Bitmap img3 = new Bitmap("photo/" + "documents.png");
                dataGridView1.Rows.Add(dr["idmembre"].ToString(), img, dr["nom_membre"].ToString(), dr["prenom_membre"].ToString(), dr["tel_membre"].ToString(), dr["email_membre"].ToString(), img3, img2, img1); ;

            }
            db.close(dr);
        }
        private void Member_Load(object sender, EventArgs e)
        {
            remplirMembers();
        }
        public void AddButton()
        {
            DataGridViewButtonColumn EditButton = new DataGridViewButtonColumn();
            EditButton.UseColumnTextForButtonValue = true;
            EditButton.DataPropertyName = "btnColumn";
            EditButton.Text = "Button Text";
            dataGridView1.Columns.Add(EditButton);
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MSG!!!!205, 37, 74");
        }

        private void ButtonAddNewMember_Click(object sender, EventArgs e)
        {
            roleFormMember = "Add";
            // Form1 f=new Form1();
            Form1.ClickedM();

            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NNzizia");
        }


        public static string id = "1";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex] == dataGridView1.Columns["CheckHistory"])
                {
                    id = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Form1.ClickedMemberHistory();
                    return;
                }
                if (senderGrid.Columns[e.ColumnIndex] == dataGridView1.Columns["Modify"])
                {
                    id = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    roleFormMember = "Modify";
                    Form1.ClickedM();
                    return;
                }
                if (senderGrid.Columns[e.ColumnIndex] == dataGridView1.Columns["Delete"])
                {
                    id = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DialogResult re = MessageBox.Show("Are you sure you want to delete this Member !!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult.Yes == re)
                    {
                        //demande_product
                        db.Excute("DELETE FROM demande_product WHERE idmembre = '" + id + "'");
                        db.Excute("DELETE FROM abonnee WHERE idmembre = '" + id + "'");
                        db.Excute("DELETE FROM demande WHERE idmembre = '" + id + "'");
                        db.Excute("DELETE FROM membre WHERE idmembre = '" + id + "'");
                        MessageBox.Show(" Deleted!!!!");
                        remplirMembers();
                        return;


                    }
                }
            }


        }
        //
        public static string roleFormMember = "";

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
                    if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["CheckHistory"] && e.RowIndex >= 0)
                    {
                        dataGridView1.Cursor = Cursors.Hand;
                        dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Empty;

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " Leave");
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
                    if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["CheckHistory"] && e.RowIndex >= 0)
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dr = db.remplir("select idmembre, nom_membre, prenom_membre, tel_membre, email_membre, photo from membre  where (nom_membre+' '+prenom_membre)like '%" + txtNameMember.Text + "%'");
            if (dataGridView1.Rows.Count >= 1)
            {
                dataGridView1.Rows.Clear();
            }
            while (dr.Read())
            {
                Bitmap img = new Bitmap(dr["photo"].ToString());
                Bitmap img1 = new Bitmap("delete_trash.png");
                Bitmap img2 = new Bitmap("modify.png");
                Bitmap img3 = new Bitmap("documents.png");
                dataGridView1.Rows.Add(dr["idmembre"].ToString(), img, dr["nom_membre"].ToString(), dr["prenom_membre"].ToString(), dr["tel_membre"].ToString(), dr["email_membre"].ToString(), img3, img2, img1);
            }
        }
    }
}

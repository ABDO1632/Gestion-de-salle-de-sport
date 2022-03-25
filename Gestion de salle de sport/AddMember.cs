using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Gestion_de_salle_de_sport
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void button_choosePhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Photo.ShowDialog() == DialogResult.OK)
            {
                string extention = Path.GetExtension(openFileDialog_Photo.FileName);
                string name = DateTime.Now.ToString().Replace(" ", "").Replace("/", "").Replace(":", "");
                Random rnd = new Random();
                name = name + rnd.Next() + extention;
                File.Copy(openFileDialog_Photo.FileName, "photo/" + name);
                //image_produitTextBox.Text = name;
            }
        }
    }
}

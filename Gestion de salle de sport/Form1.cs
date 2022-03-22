﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_de_salle_de_sport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paneChild.Controls.Add(childForm);
            paneChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Member());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new Equipment());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new Statistics());
        }
    }
}
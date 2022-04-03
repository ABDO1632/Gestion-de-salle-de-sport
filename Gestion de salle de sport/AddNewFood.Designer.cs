namespace Gestion_de_salle_de_sport
{
    partial class AddNewFood
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewFood));
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxFoods = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.button_choosePhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonModifyFood = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddfood = new FontAwesome.Sharp.IconButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.openFileDialog_Photo = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxFoods);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 372);
            this.panel2.TabIndex = 11;
            // 
            // comboBoxFoods
            // 
            this.comboBoxFoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.comboBoxFoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFoods.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxFoods.FormattingEnabled = true;
            this.comboBoxFoods.Location = new System.Drawing.Point(0, 144);
            this.comboBoxFoods.Name = "comboBoxFoods";
            this.comboBoxFoods.Size = new System.Drawing.Size(385, 28);
            this.comboBoxFoods.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Choose food :";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "drink",
            "food"});
            this.comboBox1.Location = new System.Drawing.Point(0, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(385, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrice.HintForeColor = System.Drawing.Color.DimGray;
            this.txtPrice.HintText = "Price";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtPrice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtPrice.LineThickness = 3;
            this.txtPrice.Location = new System.Drawing.Point(0, 49);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(385, 49);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.HintForeColor = System.Drawing.Color.DimGray;
            this.txtName.HintText = "Enter Name Food";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(0, 0);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(385, 49);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.imageTextBox);
            this.panel5.Controls.Add(this.button_choosePhoto);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(385, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(415, 372);
            this.panel5.TabIndex = 10;
            // 
            // imageTextBox
            // 
            this.imageTextBox.Location = new System.Drawing.Point(6, 276);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(168, 20);
            this.imageTextBox.TabIndex = 40;
            this.imageTextBox.Visible = false;
            // 
            // button_choosePhoto
            // 
            this.button_choosePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.button_choosePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_choosePhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_choosePhoto.FlatAppearance.BorderSize = 0;
            this.button_choosePhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.button_choosePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.button_choosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_choosePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_choosePhoto.ForeColor = System.Drawing.Color.Black;
            this.button_choosePhoto.Location = new System.Drawing.Point(0, 220);
            this.button_choosePhoto.Name = "button_choosePhoto";
            this.button_choosePhoto.Size = new System.Drawing.Size(415, 50);
            this.button_choosePhoto.TabIndex = 38;
            this.button_choosePhoto.Text = "CHOOSE PHOTO";
            this.button_choosePhoto.UseVisualStyleBackColor = false;
            this.button_choosePhoto.Click += new System.EventHandler(this.button_choosePhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Gestion_de_salle_de_sport.Properties.Resources.food_64px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButtonModifyFood);
            this.panel1.Controls.Add(this.iconButtonAddfood);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 9;
            // 
            // iconButtonModifyFood
            // 
            this.iconButtonModifyFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.iconButtonModifyFood.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonModifyFood.FlatAppearance.BorderSize = 0;
            this.iconButtonModifyFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonModifyFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonModifyFood.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonModifyFood.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.iconButtonModifyFood.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonModifyFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonModifyFood.Location = new System.Drawing.Point(272, 0);
            this.iconButtonModifyFood.Name = "iconButtonModifyFood";
            this.iconButtonModifyFood.Size = new System.Drawing.Size(272, 78);
            this.iconButtonModifyFood.TabIndex = 1;
            this.iconButtonModifyFood.Text = "Modify Food";
            this.iconButtonModifyFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonModifyFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonModifyFood.UseVisualStyleBackColor = false;
            this.iconButtonModifyFood.Click += new System.EventHandler(this.iconButtonModifyFood_Click);
            // 
            // iconButtonAddfood
            // 
            this.iconButtonAddfood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.iconButtonAddfood.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonAddfood.FlatAppearance.BorderSize = 0;
            this.iconButtonAddfood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddfood.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonAddfood.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.iconButtonAddfood.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonAddfood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddfood.Location = new System.Drawing.Point(0, 0);
            this.iconButtonAddfood.Name = "iconButtonAddfood";
            this.iconButtonAddfood.Size = new System.Drawing.Size(272, 78);
            this.iconButtonAddfood.TabIndex = 0;
            this.iconButtonAddfood.Text = "Add New Food";
            this.iconButtonAddfood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAddfood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddfood.UseVisualStyleBackColor = false;
            this.iconButtonAddfood.Click += new System.EventHandler(this.iconButtonAddfood_Click);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImageColumn1.FillWeight = 6.516638F;
            this.dataGridViewImageColumn1.HeaderText = "photo";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 20;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 90;
            // 
            // openFileDialog_Photo
            // 
            this.openFileDialog_Photo.FileName = "openFileDialog1";
            // 
            // AddNewFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "AddNewFood";
            this.Text = "AddNewFood";
            this.Load += new System.EventHandler(this.AddNewFood_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.Button button_choosePhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonModifyFood;
        private FontAwesome.Sharp.IconButton iconButtonAddfood;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Photo;
        private System.Windows.Forms.ComboBox comboBoxFoods;
        private System.Windows.Forms.Label label1;
    }
}
namespace Gestion_de_salle_de_sport
{
    partial class AddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMember));
            this.txtFName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonModifyMember = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddNewMember = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.button_choosePhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtWeight = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtHeight = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtHealth = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DatepickerDateN = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.openFileDialog_Photo = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFName.HintForeColor = System.Drawing.Color.DimGray;
            this.txtFName.HintText = "Enter First Name";
            this.txtFName.isPassword = false;
            this.txtFName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtFName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtFName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtFName.LineThickness = 3;
            this.txtFName.Location = new System.Drawing.Point(0, 0);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(448, 49);
            this.txtFName.TabIndex = 1;
            this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButtonModifyMember);
            this.panel1.Controls.Add(this.iconButtonAddNewMember);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 78);
            this.panel1.TabIndex = 2;
            // 
            // iconButtonModifyMember
            // 
            this.iconButtonModifyMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.iconButtonModifyMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonModifyMember.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonModifyMember.FlatAppearance.BorderSize = 0;
            this.iconButtonModifyMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonModifyMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonModifyMember.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonModifyMember.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonModifyMember.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonModifyMember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonModifyMember.Location = new System.Drawing.Point(281, 0);
            this.iconButtonModifyMember.Name = "iconButtonModifyMember";
            this.iconButtonModifyMember.Size = new System.Drawing.Size(281, 78);
            this.iconButtonModifyMember.TabIndex = 1;
            this.iconButtonModifyMember.Text = "Modify Member";
            this.iconButtonModifyMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonModifyMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonModifyMember.UseVisualStyleBackColor = false;
            this.iconButtonModifyMember.Click += new System.EventHandler(this.iconButtonModifyMember_Click);
            // 
            // iconButtonAddNewMember
            // 
            this.iconButtonAddNewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.iconButtonAddNewMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonAddNewMember.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonAddNewMember.FlatAppearance.BorderSize = 0;
            this.iconButtonAddNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddNewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddNewMember.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonAddNewMember.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButtonAddNewMember.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonAddNewMember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddNewMember.Location = new System.Drawing.Point(0, 0);
            this.iconButtonAddNewMember.Name = "iconButtonAddNewMember";
            this.iconButtonAddNewMember.Size = new System.Drawing.Size(281, 78);
            this.iconButtonAddNewMember.TabIndex = 0;
            this.iconButtonAddNewMember.Text = "Add New Member";
            this.iconButtonAddNewMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAddNewMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddNewMember.UseVisualStyleBackColor = false;
            this.iconButtonAddNewMember.Click += new System.EventHandler(this.iconButtonAddNewMember_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 574);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 30);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.imageTextBox);
            this.panel5.Controls.Add(this.button_choosePhoto);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(448, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(415, 496);
            this.panel5.TabIndex = 5;
            // 
            // imageTextBox
            // 
            this.imageTextBox.Location = new System.Drawing.Point(0, 274);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(168, 20);
            this.imageTextBox.TabIndex = 39;
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
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.txtFat);
            this.panel2.Controls.Add(this.txtWeight);
            this.panel2.Controls.Add(this.txtHeight);
            this.panel2.Controls.Add(this.txtHealth);
            this.panel2.Controls.Add(this.DatepickerDateN);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtLName);
            this.panel2.Controls.Add(this.txtFName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 496);
            this.panel2.TabIndex = 5;
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
            "male",
            "female"});
            this.comboBox1.Location = new System.Drawing.Point(0, 441);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(448, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // txtFat
            // 
            this.txtFat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFat.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFat.HintForeColor = System.Drawing.Color.DimGray;
            this.txtFat.HintText = "Enter Fat Percentage";
            this.txtFat.isPassword = false;
            this.txtFat.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtFat.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtFat.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtFat.LineThickness = 3;
            this.txtFat.Location = new System.Drawing.Point(0, 392);
            this.txtFat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(448, 49);
            this.txtFat.TabIndex = 9;
            this.txtFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            this.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtWeight.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtWeight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtWeight.HintForeColor = System.Drawing.Color.DimGray;
            this.txtWeight.HintText = "Enter Weight";
            this.txtWeight.isPassword = false;
            this.txtWeight.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtWeight.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtWeight.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtWeight.LineThickness = 3;
            this.txtWeight.Location = new System.Drawing.Point(0, 343);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(448, 49);
            this.txtWeight.TabIndex = 8;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHeight
            // 
            this.txtHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHeight.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHeight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtHeight.HintForeColor = System.Drawing.Color.DimGray;
            this.txtHeight.HintText = "Enter Height";
            this.txtHeight.isPassword = false;
            this.txtHeight.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtHeight.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtHeight.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtHeight.LineThickness = 3;
            this.txtHeight.Location = new System.Drawing.Point(0, 294);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(448, 49);
            this.txtHeight.TabIndex = 7;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHealth
            // 
            this.txtHealth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHealth.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHealth.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHealth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtHealth.HintForeColor = System.Drawing.Color.DimGray;
            this.txtHealth.HintText = "Enter Health State";
            this.txtHealth.isPassword = false;
            this.txtHealth.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtHealth.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtHealth.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtHealth.LineThickness = 3;
            this.txtHealth.Location = new System.Drawing.Point(0, 245);
            this.txtHealth.Margin = new System.Windows.Forms.Padding(4);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(448, 49);
            this.txtHealth.TabIndex = 6;
            this.txtHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DatepickerDateN
            // 
            this.DatepickerDateN.BackColor = System.Drawing.Color.Transparent;
            this.DatepickerDateN.BorderRadius = 0;
            this.DatepickerDateN.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatepickerDateN.ForeColor = System.Drawing.Color.Gray;
            this.DatepickerDateN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatepickerDateN.FormatCustom = null;
            this.DatepickerDateN.Location = new System.Drawing.Point(0, 196);
            this.DatepickerDateN.Name = "DatepickerDateN";
            this.DatepickerDateN.Size = new System.Drawing.Size(448, 49);
            this.DatepickerDateN.TabIndex = 5;
            this.DatepickerDateN.Value = new System.DateTime(2022, 3, 25, 0, 39, 57, 797);
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPhone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhone.HintForeColor = System.Drawing.Color.DimGray;
            this.txtPhone.HintText = "Phone number";
            this.txtPhone.isPassword = false;
            this.txtPhone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtPhone.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtPhone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtPhone.LineThickness = 3;
            this.txtPhone.Location = new System.Drawing.Point(0, 147);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(448, 49);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.HintForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.HintText = "Enter Email";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(0, 98);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(448, 49);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLName
            // 
            this.txtLName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLName.HintForeColor = System.Drawing.Color.DimGray;
            this.txtLName.HintText = "Enter Last Name";
            this.txtLName.isPassword = false;
            this.txtLName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtLName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtLName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtLName.LineThickness = 3;
            this.txtLName.Location = new System.Drawing.Point(0, 49);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(448, 49);
            this.txtLName.TabIndex = 2;
            this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog_Photo
            // 
            this.openFileDialog_Photo.FileName = "openFileDialog1";
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(863, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AddMember";
            this.Text = "AddMember";
            this.Load += new System.EventHandler(this.AddMember_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFName;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonAddNewMember;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLName;
        private System.Windows.Forms.Button button_choosePhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Photo;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerDateN;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtWeight;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHeight;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHealth;
        private FontAwesome.Sharp.IconButton iconButtonModifyMember;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
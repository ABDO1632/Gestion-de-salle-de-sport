namespace Gestion_de_salle_de_sport
{
    partial class AddNewEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewEquipment));
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_choosePhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonAddEquipment = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQte = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtState = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMusclTarger = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.iconButtonModifyEquipment = new FontAwesome.Sharp.IconButton();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button_choosePhoto);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(471, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(415, 445);
            this.panel5.TabIndex = 7;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButtonModifyEquipment);
            this.panel1.Controls.Add(this.iconButtonAddEquipment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 78);
            this.panel1.TabIndex = 6;
            // 
            // iconButtonAddEquipment
            // 
            this.iconButtonAddEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.iconButtonAddEquipment.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonAddEquipment.FlatAppearance.BorderSize = 0;
            this.iconButtonAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddEquipment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonAddEquipment.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.iconButtonAddEquipment.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonAddEquipment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddEquipment.Location = new System.Drawing.Point(0, 0);
            this.iconButtonAddEquipment.Name = "iconButtonAddEquipment";
            this.iconButtonAddEquipment.Size = new System.Drawing.Size(272, 78);
            this.iconButtonAddEquipment.TabIndex = 0;
            this.iconButtonAddEquipment.Text = "Add New Equipment";
            this.iconButtonAddEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAddEquipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddEquipment.UseVisualStyleBackColor = false;
            this.iconButtonAddEquipment.Click += new System.EventHandler(this.iconButtonAddEquipment_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtQte);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtState);
            this.panel2.Controls.Add(this.txtMusclTarger);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 445);
            this.panel2.TabIndex = 8;
            // 
            // txtQte
            // 
            this.txtQte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQte.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQte.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtQte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtQte.HintForeColor = System.Drawing.Color.DimGray;
            this.txtQte.HintText = "Enter Quantity";
            this.txtQte.isPassword = false;
            this.txtQte.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtQte.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtQte.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtQte.LineThickness = 3;
            this.txtQte.Location = new System.Drawing.Point(0, 196);
            this.txtQte.Margin = new System.Windows.Forms.Padding(4);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(471, 49);
            this.txtQte.TabIndex = 6;
            this.txtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrice.HintForeColor = System.Drawing.Color.DimGray;
            this.txtPrice.HintText = "Enter Price";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtPrice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtPrice.LineThickness = 3;
            this.txtPrice.Location = new System.Drawing.Point(0, 147);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(471, 49);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtState
            // 
            this.txtState.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtState.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtState.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtState.HintForeColor = System.Drawing.Color.DimGray;
            this.txtState.HintText = "Enter State";
            this.txtState.isPassword = false;
            this.txtState.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtState.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtState.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtState.LineThickness = 3;
            this.txtState.Location = new System.Drawing.Point(0, 98);
            this.txtState.Margin = new System.Windows.Forms.Padding(4);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(471, 49);
            this.txtState.TabIndex = 3;
            this.txtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMusclTarger
            // 
            this.txtMusclTarger.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMusclTarger.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMusclTarger.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMusclTarger.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMusclTarger.HintForeColor = System.Drawing.Color.DimGray;
            this.txtMusclTarger.HintText = "Enter muscl_target";
            this.txtMusclTarger.isPassword = false;
            this.txtMusclTarger.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtMusclTarger.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtMusclTarger.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtMusclTarger.LineThickness = 3;
            this.txtMusclTarger.Location = new System.Drawing.Point(0, 49);
            this.txtMusclTarger.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusclTarger.Name = "txtMusclTarger";
            this.txtMusclTarger.Size = new System.Drawing.Size(471, 49);
            this.txtMusclTarger.TabIndex = 2;
            this.txtMusclTarger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.HintForeColor = System.Drawing.Color.DimGray;
            this.txtName.HintText = "Enter Name";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(0, 0);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(471, 49);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconButtonModifyEquipment
            // 
            this.iconButtonModifyEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.iconButtonModifyEquipment.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonModifyEquipment.FlatAppearance.BorderSize = 0;
            this.iconButtonModifyEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonModifyEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonModifyEquipment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonModifyEquipment.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.iconButtonModifyEquipment.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonModifyEquipment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonModifyEquipment.Location = new System.Drawing.Point(272, 0);
            this.iconButtonModifyEquipment.Name = "iconButtonModifyEquipment";
            this.iconButtonModifyEquipment.Size = new System.Drawing.Size(272, 78);
            this.iconButtonModifyEquipment.TabIndex = 1;
            this.iconButtonModifyEquipment.Text = "Modify Equipment";
            this.iconButtonModifyEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonModifyEquipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonModifyEquipment.UseVisualStyleBackColor = false;
            this.iconButtonModifyEquipment.Click += new System.EventHandler(this.iconButtonModifyEquipment_Click);
            // 
            // AddNewEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(886, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "AddNewEquipment";
            this.Text = "AddNewEquipment";
            this.Load += new System.EventHandler(this.AddNewEquipment_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_choosePhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonAddEquipment;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQte;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtState;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMusclTarger;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private FontAwesome.Sharp.IconButton iconButtonModifyEquipment;
    }
}
namespace Gestion_de_salle_de_sport
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonAddNewEquipment = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.NameEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muscl_target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buttons = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconButton2);
            this.panel3.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 126);
            this.panel3.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(317, 47);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(47, 41);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox1.HintText = "Search for an Equipment";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(43, 44);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(250, 44);
            this.bunifuMaterialTextbox1.TabIndex = 0;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 126);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonAddNewEquipment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(564, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 126);
            this.panel1.TabIndex = 2;
            // 
            // ButtonAddNewEquipment
            // 
            this.ButtonAddNewEquipment.ActiveBorderThickness = 1;
            this.ButtonAddNewEquipment.ActiveCornerRadius = 50;
            this.ButtonAddNewEquipment.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.ButtonAddNewEquipment.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAddNewEquipment.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.ButtonAddNewEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ButtonAddNewEquipment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAddNewEquipment.BackgroundImage")));
            this.ButtonAddNewEquipment.ButtonText = "Add New Equipment";
            this.ButtonAddNewEquipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddNewEquipment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddNewEquipment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAddNewEquipment.IdleBorderThickness = 1;
            this.ButtonAddNewEquipment.IdleCornerRadius = 50;
            this.ButtonAddNewEquipment.IdleFillColor = System.Drawing.Color.Transparent;
            this.ButtonAddNewEquipment.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAddNewEquipment.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.ButtonAddNewEquipment.Location = new System.Drawing.Point(9, 33);
            this.ButtonAddNewEquipment.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonAddNewEquipment.Name = "ButtonAddNewEquipment";
            this.ButtonAddNewEquipment.Size = new System.Drawing.Size(213, 64);
            this.ButtonAddNewEquipment.TabIndex = 1;
            this.ButtonAddNewEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonAddNewEquipment.Click += new System.EventHandler(this.ButtonAddNewEquipment_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 324);
            this.panel4.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmembre,
            this.photo,
            this.NameEquipment,
            this.muscl_target,
            this.State,
            this.prix,
            this.quantity,
            this.Buttons});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 150;
            this.dataGridView1.Size = new System.Drawing.Size(800, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // idmembre
            // 
            this.idmembre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idmembre.FillWeight = 2.896616F;
            this.idmembre.HeaderText = "id";
            this.idmembre.MinimumWidth = 28;
            this.idmembre.Name = "idmembre";
            this.idmembre.Width = 28;
            // 
            // photo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            this.photo.DefaultCellStyle = dataGridViewCellStyle3;
            this.photo.FillWeight = 6.833045F;
            this.photo.HeaderText = "photo";
            this.photo.Image = ((System.Drawing.Image)(resources.GetObject("photo.Image")));
            this.photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.photo.MinimumWidth = 20;
            this.photo.Name = "photo";
            this.photo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.photo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NameEquipment
            // 
            this.NameEquipment.FillWeight = 6.833045F;
            this.NameEquipment.HeaderText = "Name Equipment";
            this.NameEquipment.MinimumWidth = 20;
            this.NameEquipment.Name = "NameEquipment";
            // 
            // muscl_target
            // 
            this.muscl_target.FillWeight = 6.833045F;
            this.muscl_target.HeaderText = "targeted muscles";
            this.muscl_target.MinimumWidth = 20;
            this.muscl_target.Name = "muscl_target";
            // 
            // State
            // 
            this.State.FillWeight = 6.833045F;
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 20;
            this.State.Name = "State";
            // 
            // prix
            // 
            this.prix.FillWeight = 6.833045F;
            this.prix.HeaderText = "Price";
            this.prix.MinimumWidth = 22;
            this.prix.Name = "prix";
            // 
            // quantity
            // 
            this.quantity.FillWeight = 6.833045F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // Buttons
            // 
            this.Buttons.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Buttons.FillWeight = 6.833045F;
            this.Buttons.HeaderText = "Buttons";
            this.Buttons.MinimumWidth = 10;
            this.Buttons.Name = "Buttons";
            this.Buttons.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Buttons.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Buttons.Width = 50;
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "Equipment";
            this.Text = "Equipment";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonAddNewEquipment;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmembre;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn muscl_target;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewButtonColumn Buttons;
    }
}
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
            this.BtnSearch = new FontAwesome.Sharp.IconButton();
            this.txtNameEquipment = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonAddNewEquipment = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.NameEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetedMuscles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnSearch);
            this.panel3.Controls.Add(this.txtNameEquipment);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 126);
            this.panel3.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.BtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearch.IconSize = 40;
            this.BtnSearch.Location = new System.Drawing.Point(317, 47);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(47, 41);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtNameEquipment
            // 
            this.txtNameEquipment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameEquipment.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNameEquipment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNameEquipment.HintForeColor = System.Drawing.Color.DimGray;
            this.txtNameEquipment.HintText = "Search for an Equipment";
            this.txtNameEquipment.isPassword = false;
            this.txtNameEquipment.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtNameEquipment.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtNameEquipment.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtNameEquipment.LineThickness = 3;
            this.txtNameEquipment.Location = new System.Drawing.Point(43, 44);
            this.txtNameEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameEquipment.Name = "txtNameEquipment";
            this.txtNameEquipment.Size = new System.Drawing.Size(250, 44);
            this.txtNameEquipment.TabIndex = 0;
            this.txtNameEquipment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.idE,
            this.photo,
            this.NameEquipment,
            this.TargetedMuscles,
            this.State,
            this.Price,
            this.Quantity,
            this.Modify,
            this.Delete});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            // 
            // idE
            // 
            this.idE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idE.FillWeight = 2.896616F;
            this.idE.HeaderText = "id";
            this.idE.MinimumWidth = 28;
            this.idE.Name = "idE";
            this.idE.Width = 28;
            // 
            // photo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            this.photo.DefaultCellStyle = dataGridViewCellStyle3;
            this.photo.FillWeight = 6.516638F;
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
            this.NameEquipment.FillWeight = 6.516638F;
            this.NameEquipment.HeaderText = "Name Equipment";
            this.NameEquipment.MinimumWidth = 20;
            this.NameEquipment.Name = "NameEquipment";
            // 
            // TargetedMuscles
            // 
            this.TargetedMuscles.FillWeight = 6.516638F;
            this.TargetedMuscles.HeaderText = "Targeted muscles";
            this.TargetedMuscles.MinimumWidth = 20;
            this.TargetedMuscles.Name = "TargetedMuscles";
            // 
            // State
            // 
            this.State.FillWeight = 6.516638F;
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 20;
            this.State.Name = "State";
            // 
            // Price
            // 
            this.Price.FillWeight = 6.833045F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 20;
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 9.047894F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 20;
            this.Quantity.Name = "Quantity";
            // 
            // Modify
            // 
            this.Modify.FillWeight = 6.516638F;
            this.Modify.HeaderText = "";
            this.Modify.MinimumWidth = 10;
            this.Modify.Name = "Modify";
            this.Modify.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 6.516638F;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 10;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.Load += new System.EventHandler(this.Equipment_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton BtnSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNameEquipment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonAddNewEquipment;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idE;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetedMuscles;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewImageColumn Modify;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
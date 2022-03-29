namespace Gestion_de_salle_de_sport
{
    partial class Member
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.nom_membre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom_membre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_membre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_membre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckHistory = new System.Windows.Forms.DataGridViewImageColumn();
            this.Modify = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ButtonDelete = new FontAwesome.Sharp.IconButton();
            this.ButtonModifier = new FontAwesome.Sharp.IconButton();
            this.ButtonMoreInfo = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonAddNewMember = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnSearch = new FontAwesome.Sharp.IconButton();
            this.txtNameMember = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmembre,
            this.photo,
            this.nom_membre,
            this.prenom_membre,
            this.tel_membre,
            this.email_membre,
            this.CheckHistory,
            this.Modify,
            this.Delete});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.Height = 150;
            this.dataGridView1.Size = new System.Drawing.Size(882, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10);
            this.photo.DefaultCellStyle = dataGridViewCellStyle8;
            this.photo.FillWeight = 6.833045F;
            this.photo.HeaderText = "photo";
            this.photo.Image = ((System.Drawing.Image)(resources.GetObject("photo.Image")));
            this.photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.photo.MinimumWidth = 20;
            this.photo.Name = "photo";
            this.photo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.photo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nom_membre
            // 
            this.nom_membre.FillWeight = 6.833045F;
            this.nom_membre.HeaderText = "First Name";
            this.nom_membre.MinimumWidth = 20;
            this.nom_membre.Name = "nom_membre";
            // 
            // prenom_membre
            // 
            this.prenom_membre.FillWeight = 6.833045F;
            this.prenom_membre.HeaderText = "Last Name";
            this.prenom_membre.MinimumWidth = 20;
            this.prenom_membre.Name = "prenom_membre";
            // 
            // tel_membre
            // 
            this.tel_membre.FillWeight = 6.833045F;
            this.tel_membre.HeaderText = "Phone Number";
            this.tel_membre.MinimumWidth = 20;
            this.tel_membre.Name = "tel_membre";
            // 
            // email_membre
            // 
            this.email_membre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.email_membre.FillWeight = 37.44002F;
            this.email_membre.HeaderText = "Email";
            this.email_membre.MinimumWidth = 22;
            this.email_membre.Name = "email_membre";
            this.email_membre.Width = 200;
            // 
            // CheckHistory
            // 
            this.CheckHistory.FillWeight = 6.833045F;
            this.CheckHistory.HeaderText = "";
            this.CheckHistory.MinimumWidth = 10;
            this.CheckHistory.Name = "CheckHistory";
            this.CheckHistory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckHistory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Modify
            // 
            this.Modify.FillWeight = 6.833045F;
            this.Modify.HeaderText = "";
            this.Modify.MinimumWidth = 10;
            this.Modify.Name = "Modify";
            this.Modify.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 6.833045F;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 10;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(80)))));
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ButtonDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDelete.IconSize = 30;
            this.ButtonDelete.Location = new System.Drawing.Point(817, 384);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(50, 42);
            this.ButtonDelete.TabIndex = 1;
            this.ButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonModifier
            // 
            this.ButtonModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(73)))), ((int)(((byte)(180)))));
            this.ButtonModifier.FlatAppearance.BorderSize = 0;
            this.ButtonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonModifier.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.ButtonModifier.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ButtonModifier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonModifier.IconSize = 30;
            this.ButtonModifier.Location = new System.Drawing.Point(761, 384);
            this.ButtonModifier.Name = "ButtonModifier";
            this.ButtonModifier.Size = new System.Drawing.Size(50, 42);
            this.ButtonModifier.TabIndex = 2;
            this.ButtonModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonModifier.UseVisualStyleBackColor = false;
            // 
            // ButtonMoreInfo
            // 
            this.ButtonMoreInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(73)))), ((int)(((byte)(180)))));
            this.ButtonMoreInfo.FlatAppearance.BorderSize = 0;
            this.ButtonMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMoreInfo.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.ButtonMoreInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ButtonMoreInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonMoreInfo.IconSize = 30;
            this.ButtonMoreInfo.Location = new System.Drawing.Point(705, 384);
            this.ButtonMoreInfo.Name = "ButtonMoreInfo";
            this.ButtonMoreInfo.Size = new System.Drawing.Size(50, 42);
            this.ButtonMoreInfo.TabIndex = 3;
            this.ButtonMoreInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonMoreInfo.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 126);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonAddNewMember);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(646, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 126);
            this.panel1.TabIndex = 2;
            // 
            // ButtonAddNewMember
            // 
            this.ButtonAddNewMember.ActiveBorderThickness = 1;
            this.ButtonAddNewMember.ActiveCornerRadius = 50;
            this.ButtonAddNewMember.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.ButtonAddNewMember.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAddNewMember.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.ButtonAddNewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ButtonAddNewMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAddNewMember.BackgroundImage")));
            this.ButtonAddNewMember.ButtonText = "Add New Member";
            this.ButtonAddNewMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddNewMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddNewMember.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAddNewMember.IdleBorderThickness = 1;
            this.ButtonAddNewMember.IdleCornerRadius = 50;
            this.ButtonAddNewMember.IdleFillColor = System.Drawing.Color.Transparent;
            this.ButtonAddNewMember.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAddNewMember.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.ButtonAddNewMember.Location = new System.Drawing.Point(9, 33);
            this.ButtonAddNewMember.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonAddNewMember.Name = "ButtonAddNewMember";
            this.ButtonAddNewMember.Size = new System.Drawing.Size(213, 64);
            this.ButtonAddNewMember.TabIndex = 1;
            this.ButtonAddNewMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonAddNewMember.Click += new System.EventHandler(this.ButtonAddNewMember_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnSearch);
            this.panel3.Controls.Add(this.txtNameMember);
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
            // txtNameMember
            // 
            this.txtNameMember.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameMember.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNameMember.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNameMember.HintForeColor = System.Drawing.Color.DimGray;
            this.txtNameMember.HintText = "Search for a member";
            this.txtNameMember.isPassword = false;
            this.txtNameMember.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtNameMember.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            this.txtNameMember.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.txtNameMember.LineThickness = 3;
            this.txtNameMember.Location = new System.Drawing.Point(43, 44);
            this.txtNameMember.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameMember.Name = "txtNameMember";
            this.txtNameMember.Size = new System.Drawing.Size(250, 44);
            this.txtNameMember.TabIndex = 0;
            this.txtNameMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(882, 324);
            this.panel4.TabIndex = 6;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonMoreInfo);
            this.Controls.Add(this.ButtonModifier);
            this.Controls.Add(this.ButtonDelete);
            this.Name = "Member";
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton ButtonDelete;
        private FontAwesome.Sharp.IconButton ButtonModifier;
        private FontAwesome.Sharp.IconButton ButtonMoreInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNameMember;
        private FontAwesome.Sharp.IconButton BtnSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonAddNewMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmembre;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_membre;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom_membre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_membre;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_membre;
        private System.Windows.Forms.DataGridViewImageColumn CheckHistory;
        private System.Windows.Forms.DataGridViewImageColumn Modify;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
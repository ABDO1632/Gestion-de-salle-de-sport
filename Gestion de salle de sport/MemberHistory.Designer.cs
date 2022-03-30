namespace Gestion_de_salle_de_sport
{
    partial class MemberHistory
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
            System.Windows.Forms.Label idmembreLabel;
            System.Windows.Forms.Label nom_membreLabel;
            System.Windows.Forms.Label prenom_membreLabel;
            System.Windows.Forms.Label tel_membreLabel;
            System.Windows.Forms.Label email_membreLabel;
            System.Windows.Forms.Label date_naissLabel;
            System.Windows.Forms.Label health_statueLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label fatLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payement_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expire_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idmembreTextBox = new System.Windows.Forms.TextBox();
            this.nom_membreTextBox = new System.Windows.Forms.TextBox();
            this.prenom_membreTextBox = new System.Windows.Forms.TextBox();
            this.tel_membreTextBox = new System.Windows.Forms.TextBox();
            this.email_membreTextBox = new System.Windows.Forms.TextBox();
            this.health_statueTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            idmembreLabel = new System.Windows.Forms.Label();
            nom_membreLabel = new System.Windows.Forms.Label();
            prenom_membreLabel = new System.Windows.Forms.Label();
            tel_membreLabel = new System.Windows.Forms.Label();
            email_membreLabel = new System.Windows.Forms.Label();
            date_naissLabel = new System.Windows.Forms.Label();
            health_statueLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            fatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idmembreLabel
            // 
            idmembreLabel.AutoSize = true;
            idmembreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idmembreLabel.ForeColor = System.Drawing.Color.LightGray;
            idmembreLabel.Location = new System.Drawing.Point(185, 12);
            idmembreLabel.Name = "idmembreLabel";
            idmembreLabel.Size = new System.Drawing.Size(83, 20);
            idmembreLabel.TabIndex = 25;
            idmembreLabel.Text = "idmembre:";
            // 
            // nom_membreLabel
            // 
            nom_membreLabel.AutoSize = true;
            nom_membreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_membreLabel.ForeColor = System.Drawing.Color.LightGray;
            nom_membreLabel.Location = new System.Drawing.Point(185, 38);
            nom_membreLabel.Name = "nom_membreLabel";
            nom_membreLabel.Size = new System.Drawing.Size(106, 20);
            nom_membreLabel.TabIndex = 27;
            nom_membreLabel.Text = "nom membre:";
            // 
            // prenom_membreLabel
            // 
            prenom_membreLabel.AutoSize = true;
            prenom_membreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenom_membreLabel.ForeColor = System.Drawing.Color.LightGray;
            prenom_membreLabel.Location = new System.Drawing.Point(185, 64);
            prenom_membreLabel.Name = "prenom_membreLabel";
            prenom_membreLabel.Size = new System.Drawing.Size(129, 20);
            prenom_membreLabel.TabIndex = 29;
            prenom_membreLabel.Text = "prenom membre:";
            // 
            // tel_membreLabel
            // 
            tel_membreLabel.AutoSize = true;
            tel_membreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tel_membreLabel.ForeColor = System.Drawing.Color.LightGray;
            tel_membreLabel.Location = new System.Drawing.Point(185, 90);
            tel_membreLabel.Name = "tel_membreLabel";
            tel_membreLabel.Size = new System.Drawing.Size(92, 20);
            tel_membreLabel.TabIndex = 31;
            tel_membreLabel.Text = "tel membre:";
            // 
            // email_membreLabel
            // 
            email_membreLabel.AutoSize = true;
            email_membreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            email_membreLabel.ForeColor = System.Drawing.Color.LightGray;
            email_membreLabel.Location = new System.Drawing.Point(185, 116);
            email_membreLabel.Name = "email_membreLabel";
            email_membreLabel.Size = new System.Drawing.Size(112, 20);
            email_membreLabel.TabIndex = 33;
            email_membreLabel.Text = "email membre:";
            // 
            // date_naissLabel
            // 
            date_naissLabel.AutoSize = true;
            date_naissLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_naissLabel.ForeColor = System.Drawing.Color.LightGray;
            date_naissLabel.Location = new System.Drawing.Point(547, 9);
            date_naissLabel.Name = "date_naissLabel";
            date_naissLabel.Size = new System.Drawing.Size(86, 20);
            date_naissLabel.TabIndex = 35;
            date_naissLabel.Text = "date naiss:";
            // 
            // health_statueLabel
            // 
            health_statueLabel.AutoSize = true;
            health_statueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            health_statueLabel.ForeColor = System.Drawing.Color.LightGray;
            health_statueLabel.Location = new System.Drawing.Point(524, 35);
            health_statueLabel.Name = "health_statueLabel";
            health_statueLabel.Size = new System.Drawing.Size(109, 20);
            health_statueLabel.TabIndex = 39;
            health_statueLabel.Text = "Health statue:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            heightLabel.ForeColor = System.Drawing.Color.LightGray;
            heightLabel.Location = new System.Drawing.Point(563, 61);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(60, 20);
            heightLabel.TabIndex = 43;
            heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            weightLabel.ForeColor = System.Drawing.Color.LightGray;
            weightLabel.Location = new System.Drawing.Point(563, 87);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(63, 20);
            weightLabel.TabIndex = 45;
            weightLabel.Text = "Weight:";
            // 
            // fatLabel
            // 
            fatLabel.AutoSize = true;
            fatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fatLabel.ForeColor = System.Drawing.Color.LightGray;
            fatLabel.Location = new System.Drawing.Point(563, 113);
            fatLabel.Name = "fatLabel";
            fatLabel.Size = new System.Drawing.Size(37, 20);
            fatLabel.TabIndex = 47;
            fatLabel.Text = "Fat:";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(84)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sport,
            this.Description,
            this.Amount,
            this.Payement_Date,
            this.Expire_Date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 254);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 150;
            this.dataGridView1.Size = new System.Drawing.Size(851, 213);
            this.dataGridView1.TabIndex = 1;
            // 
            // Sport
            // 
            this.Sport.FillWeight = 6.833045F;
            this.Sport.HeaderText = "Sport";
            this.Sport.MinimumWidth = 20;
            this.Sport.Name = "Sport";
            // 
            // Description
            // 
            this.Description.FillWeight = 6.833045F;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 20;
            this.Description.Name = "Description";
            // 
            // Amount
            // 
            this.Amount.FillWeight = 6.833045F;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 20;
            this.Amount.Name = "Amount";
            // 
            // Payement_Date
            // 
            this.Payement_Date.FillWeight = 6.833045F;
            this.Payement_Date.HeaderText = "Payement Date";
            this.Payement_Date.MinimumWidth = 22;
            this.Payement_Date.Name = "Payement_Date";
            // 
            // Expire_Date
            // 
            this.Expire_Date.FillWeight = 6.833045F;
            this.Expire_Date.HeaderText = "Expire Date";
            this.Expire_Date.Name = "Expire_Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // idmembreTextBox
            // 
            this.idmembreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.idmembreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idmembreTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.idmembreTextBox.Location = new System.Drawing.Point(321, 15);
            this.idmembreTextBox.Multiline = true;
            this.idmembreTextBox.Name = "idmembreTextBox";
            this.idmembreTextBox.Size = new System.Drawing.Size(200, 20);
            this.idmembreTextBox.TabIndex = 26;
            // 
            // nom_membreTextBox
            // 
            this.nom_membreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.nom_membreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nom_membreTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.nom_membreTextBox.Location = new System.Drawing.Point(321, 40);
            this.nom_membreTextBox.Multiline = true;
            this.nom_membreTextBox.Name = "nom_membreTextBox";
            this.nom_membreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nom_membreTextBox.TabIndex = 28;
            // 
            // prenom_membreTextBox
            // 
            this.prenom_membreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.prenom_membreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenom_membreTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.prenom_membreTextBox.Location = new System.Drawing.Point(321, 66);
            this.prenom_membreTextBox.Multiline = true;
            this.prenom_membreTextBox.Name = "prenom_membreTextBox";
            this.prenom_membreTextBox.Size = new System.Drawing.Size(200, 20);
            this.prenom_membreTextBox.TabIndex = 30;
            // 
            // tel_membreTextBox
            // 
            this.tel_membreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.tel_membreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tel_membreTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.tel_membreTextBox.Location = new System.Drawing.Point(321, 90);
            this.tel_membreTextBox.Multiline = true;
            this.tel_membreTextBox.Name = "tel_membreTextBox";
            this.tel_membreTextBox.Size = new System.Drawing.Size(200, 20);
            this.tel_membreTextBox.TabIndex = 32;
            // 
            // email_membreTextBox
            // 
            this.email_membreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.email_membreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_membreTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.email_membreTextBox.Location = new System.Drawing.Point(321, 118);
            this.email_membreTextBox.Multiline = true;
            this.email_membreTextBox.Name = "email_membreTextBox";
            this.email_membreTextBox.Size = new System.Drawing.Size(200, 20);
            this.email_membreTextBox.TabIndex = 34;
            // 
            // health_statueTextBox
            // 
            this.health_statueTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.health_statueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.health_statueTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.health_statueTextBox.Location = new System.Drawing.Point(639, 35);
            this.health_statueTextBox.Multiline = true;
            this.health_statueTextBox.Name = "health_statueTextBox";
            this.health_statueTextBox.Size = new System.Drawing.Size(200, 20);
            this.health_statueTextBox.TabIndex = 40;
            // 
            // heightTextBox
            // 
            this.heightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.heightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.heightTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.heightTextBox.Location = new System.Drawing.Point(639, 61);
            this.heightTextBox.Multiline = true;
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(200, 20);
            this.heightTextBox.TabIndex = 44;
            // 
            // weightTextBox
            // 
            this.weightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.weightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weightTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.weightTextBox.Location = new System.Drawing.Point(639, 87);
            this.weightTextBox.Multiline = true;
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(200, 20);
            this.weightTextBox.TabIndex = 46;
            // 
            // fatTextBox
            // 
            this.fatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.fatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fatTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.fatTextBox.Location = new System.Drawing.Point(639, 113);
            this.fatTextBox.Multiline = true;
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(200, 20);
            this.fatTextBox.TabIndex = 48;
            // 
            // textBox_Age
            // 
            this.textBox_Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.textBox_Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Age.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox_Age.Location = new System.Drawing.Point(639, 12);
            this.textBox_Age.Multiline = true;
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(200, 20);
            this.textBox_Age.TabIndex = 49;
            // 
            // MemberHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(851, 467);
            this.Controls.Add(this.textBox_Age);
            this.Controls.Add(idmembreLabel);
            this.Controls.Add(this.idmembreTextBox);
            this.Controls.Add(nom_membreLabel);
            this.Controls.Add(this.nom_membreTextBox);
            this.Controls.Add(prenom_membreLabel);
            this.Controls.Add(this.prenom_membreTextBox);
            this.Controls.Add(tel_membreLabel);
            this.Controls.Add(this.tel_membreTextBox);
            this.Controls.Add(email_membreLabel);
            this.Controls.Add(this.email_membreTextBox);
            this.Controls.Add(date_naissLabel);
            this.Controls.Add(health_statueLabel);
            this.Controls.Add(this.health_statueTextBox);
            this.Controls.Add(heightLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(fatLabel);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MemberHistory";
            this.Text = "MemberHistory";
            this.Load += new System.EventHandler(this.MemberHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payement_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expire_Date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox idmembreTextBox;
        private System.Windows.Forms.TextBox nom_membreTextBox;
        private System.Windows.Forms.TextBox prenom_membreTextBox;
        private System.Windows.Forms.TextBox tel_membreTextBox;
        private System.Windows.Forms.TextBox email_membreTextBox;
        private System.Windows.Forms.TextBox health_statueTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox fatTextBox;
        private System.Windows.Forms.TextBox textBox_Age;
    }
}
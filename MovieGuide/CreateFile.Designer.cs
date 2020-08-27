namespace MovieGuide
{
    partial class CreateFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFile));
            this.label1 = new System.Windows.Forms.Label();
            this.FileName_txt = new System.Windows.Forms.TextBox();
            this.RecordData_pnl = new System.Windows.Forms.Panel();
            this.Upload_btn = new System.Windows.Forms.Button();
            this.Poster_pic = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Rating_combo = new System.Windows.Forms.ComboBox();
            this.Year_cmbo = new System.Windows.Forms.ComboBox();
            this.Genre_lst = new System.Windows.Forms.CheckedListBox();
            this.Director_txt = new System.Windows.Forms.TextBox();
            this.Title_txt = new System.Windows.Forms.TextBox();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FileCreate_btn = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.C_Add_btn = new System.Windows.Forms.Button();
            this.RecordData_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Poster_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name:";
            // 
            // FileName_txt
            // 
            this.FileName_txt.Location = new System.Drawing.Point(209, 23);
            this.FileName_txt.Name = "FileName_txt";
            this.FileName_txt.Size = new System.Drawing.Size(154, 20);
            this.FileName_txt.TabIndex = 1;
            // 
            // RecordData_pnl
            // 
            this.RecordData_pnl.Controls.Add(this.Upload_btn);
            this.RecordData_pnl.Controls.Add(this.Poster_pic);
            this.RecordData_pnl.Controls.Add(this.label9);
            this.RecordData_pnl.Controls.Add(this.Rating_combo);
            this.RecordData_pnl.Controls.Add(this.Year_cmbo);
            this.RecordData_pnl.Controls.Add(this.Genre_lst);
            this.RecordData_pnl.Controls.Add(this.Director_txt);
            this.RecordData_pnl.Controls.Add(this.Title_txt);
            this.RecordData_pnl.Controls.Add(this.ID_txt);
            this.RecordData_pnl.Controls.Add(this.label7);
            this.RecordData_pnl.Controls.Add(this.label6);
            this.RecordData_pnl.Controls.Add(this.label5);
            this.RecordData_pnl.Controls.Add(this.label4);
            this.RecordData_pnl.Controls.Add(this.label3);
            this.RecordData_pnl.Controls.Add(this.label2);
            this.RecordData_pnl.Location = new System.Drawing.Point(12, 72);
            this.RecordData_pnl.Name = "RecordData_pnl";
            this.RecordData_pnl.Size = new System.Drawing.Size(560, 285);
            this.RecordData_pnl.TabIndex = 2;
            // 
            // Upload_btn
            // 
            this.Upload_btn.Location = new System.Drawing.Point(345, 244);
            this.Upload_btn.Name = "Upload_btn";
            this.Upload_btn.Size = new System.Drawing.Size(122, 23);
            this.Upload_btn.TabIndex = 21;
            this.Upload_btn.Text = "Upload Picture";
            this.Upload_btn.UseVisualStyleBackColor = true;
            this.Upload_btn.Click += new System.EventHandler(this.Upload_btn_Click);
            // 
            // Poster_pic
            // 
            this.Poster_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Poster_pic.BackgroundImage")));
            this.Poster_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Poster_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Poster_pic.Location = new System.Drawing.Point(293, 13);
            this.Poster_pic.Name = "Poster_pic";
            this.Poster_pic.Size = new System.Drawing.Size(225, 225);
            this.Poster_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Poster_pic.TabIndex = 20;
            this.Poster_pic.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "/10";
            // 
            // Rating_combo
            // 
            this.Rating_combo.FormattingEnabled = true;
            this.Rating_combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Rating_combo.Location = new System.Drawing.Point(72, 185);
            this.Rating_combo.Name = "Rating_combo";
            this.Rating_combo.Size = new System.Drawing.Size(155, 21);
            this.Rating_combo.TabIndex = 18;
            // 
            // Year_cmbo
            // 
            this.Year_cmbo.FormattingEnabled = true;
            this.Year_cmbo.Items.AddRange(new object[] {
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.Year_cmbo.Location = new System.Drawing.Point(72, 148);
            this.Year_cmbo.Name = "Year_cmbo";
            this.Year_cmbo.Size = new System.Drawing.Size(154, 21);
            this.Year_cmbo.TabIndex = 17;
            // 
            // Genre_lst
            // 
            this.Genre_lst.FormattingEnabled = true;
            this.Genre_lst.Items.AddRange(new object[] {
            "Adventure",
            "Action",
            "Comedy",
            "Drama",
            "Romance",
            "SciFi"});
            this.Genre_lst.Location = new System.Drawing.Point(73, 89);
            this.Genre_lst.Name = "Genre_lst";
            this.Genre_lst.ScrollAlwaysVisible = true;
            this.Genre_lst.Size = new System.Drawing.Size(154, 49);
            this.Genre_lst.TabIndex = 16;
            // 
            // Director_txt
            // 
            this.Director_txt.Location = new System.Drawing.Point(73, 218);
            this.Director_txt.Name = "Director_txt";
            this.Director_txt.Size = new System.Drawing.Size(154, 20);
            this.Director_txt.TabIndex = 11;
            this.Director_txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Title_txt
            // 
            this.Title_txt.Location = new System.Drawing.Point(63, 52);
            this.Title_txt.Name = "Title_txt";
            this.Title_txt.Size = new System.Drawing.Size(154, 20);
            this.Title_txt.TabIndex = 10;
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(63, 10);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(154, 20);
            this.ID_txt.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Director";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // FileCreate_btn
            // 
            this.FileCreate_btn.Location = new System.Drawing.Point(388, 21);
            this.FileCreate_btn.Name = "FileCreate_btn";
            this.FileCreate_btn.Size = new System.Drawing.Size(75, 23);
            this.FileCreate_btn.TabIndex = 3;
            this.FileCreate_btn.Text = "Create";
            this.FileCreate_btn.UseVisualStyleBackColor = true;
            this.FileCreate_btn.Click += new System.EventHandler(this.FileCreate_btn_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(497, 21);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(75, 23);
            this.Home_btn.TabIndex = 27;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // C_Add_btn
            // 
            this.C_Add_btn.Location = new System.Drawing.Point(12, 21);
            this.C_Add_btn.Name = "C_Add_btn";
            this.C_Add_btn.Size = new System.Drawing.Size(75, 23);
            this.C_Add_btn.TabIndex = 28;
            this.C_Add_btn.Text = "Add";
            this.C_Add_btn.UseVisualStyleBackColor = true;
            this.C_Add_btn.Click += new System.EventHandler(this.C_Add_btn_Click);
            // 
            // CreateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 369);
            this.Controls.Add(this.C_Add_btn);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.FileCreate_btn);
            this.Controls.Add(this.RecordData_pnl);
            this.Controls.Add(this.FileName_txt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateFile";
            this.Text = "CreateFile";
            this.Load += new System.EventHandler(this.Home_btn_Click);
            this.RecordData_pnl.ResumeLayout(false);
            this.RecordData_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Poster_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileName_txt;
        private System.Windows.Forms.Panel RecordData_pnl;
        private System.Windows.Forms.TextBox Director_txt;
        private System.Windows.Forms.TextBox Title_txt;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Upload_btn;
        private System.Windows.Forms.PictureBox Poster_pic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Rating_combo;
        private System.Windows.Forms.ComboBox Year_cmbo;
        private System.Windows.Forms.CheckedListBox Genre_lst;
        private System.Windows.Forms.Button FileCreate_btn;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Button C_Add_btn;
    }
}
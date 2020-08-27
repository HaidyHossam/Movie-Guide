namespace MovieGuide
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.label1 = new System.Windows.Forms.Label();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.EMovieTitle_txt = new System.Windows.Forms.TextBox();
            this.Home_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FileNA_TXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Rating_combo = new System.Windows.Forms.ComboBox();
            this.Year_cmbo = new System.Windows.Forms.ComboBox();
            this.Genree_lst = new System.Windows.Forms.CheckedListBox();
            this.Director_txt = new System.Windows.Forms.TextBox();
            this.Title_txt = new System.Windows.Forms.TextBox();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Movie Title";
            // 
            // Edit_btn
            // 
            this.Edit_btn.Location = new System.Drawing.Point(266, 41);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(75, 23);
            this.Edit_btn.TabIndex = 4;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.UseVisualStyleBackColor = true;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // EMovieTitle_txt
            // 
            this.EMovieTitle_txt.Location = new System.Drawing.Point(82, 44);
            this.EMovieTitle_txt.Name = "EMovieTitle_txt";
            this.EMovieTitle_txt.Size = new System.Drawing.Size(152, 20);
            this.EMovieTitle_txt.TabIndex = 3;
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(266, 12);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(75, 23);
            this.Home_btn.TabIndex = 6;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "FileName";
            // 
            // FileNA_TXT
            // 
            this.FileNA_TXT.Location = new System.Drawing.Point(81, 16);
            this.FileNA_TXT.Margin = new System.Windows.Forms.Padding(2);
            this.FileNA_TXT.Name = "FileNA_TXT";
            this.FileNA_TXT.Size = new System.Drawing.Size(152, 20);
            this.FileNA_TXT.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Director";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 44;
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
            this.Rating_combo.Location = new System.Drawing.Point(80, 267);
            this.Rating_combo.Name = "Rating_combo";
            this.Rating_combo.Size = new System.Drawing.Size(153, 21);
            this.Rating_combo.TabIndex = 43;
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
            this.Year_cmbo.Location = new System.Drawing.Point(79, 228);
            this.Year_cmbo.Name = "Year_cmbo";
            this.Year_cmbo.Size = new System.Drawing.Size(154, 21);
            this.Year_cmbo.TabIndex = 42;
            // 
            // Genree_lst
            // 
            this.Genree_lst.FormattingEnabled = true;
            this.Genree_lst.Items.AddRange(new object[] {
            "Adventure",
            "Action",
            "Comedy",
            "Drama",
            "Romance",
            "SciFi"});
            this.Genree_lst.Location = new System.Drawing.Point(80, 167);
            this.Genree_lst.Name = "Genree_lst";
            this.Genree_lst.ScrollAlwaysVisible = true;
            this.Genree_lst.Size = new System.Drawing.Size(153, 49);
            this.Genree_lst.TabIndex = 41;
            // 
            // Director_txt
            // 
            this.Director_txt.Location = new System.Drawing.Point(81, 304);
            this.Director_txt.Name = "Director_txt";
            this.Director_txt.Size = new System.Drawing.Size(152, 20);
            this.Director_txt.TabIndex = 40;
            // 
            // Title_txt
            // 
            this.Title_txt.Location = new System.Drawing.Point(79, 128);
            this.Title_txt.Name = "Title_txt";
            this.Title_txt.Size = new System.Drawing.Size(154, 20);
            this.Title_txt.TabIndex = 39;
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(79, 91);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(154, 20);
            this.ID_txt.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Rating";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "ID";
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(266, 300);
            this.Save_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(75, 26);
            this.Save_Btn.TabIndex = 45;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Director";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 345);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Rating_combo);
            this.Controls.Add(this.Year_cmbo);
            this.Controls.Add(this.Genree_lst);
            this.Controls.Add(this.Director_txt);
            this.Controls.Add(this.Title_txt);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FileNA_TXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.EMovieTitle_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.TextBox EMovieTitle_txt;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileNA_TXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Rating_combo;
        private System.Windows.Forms.ComboBox Year_cmbo;
        private System.Windows.Forms.CheckedListBox Genree_lst;
        private System.Windows.Forms.TextBox Director_txt;
        private System.Windows.Forms.TextBox Title_txt;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Label label10;
    }
}
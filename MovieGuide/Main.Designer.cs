namespace MovieGuide
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Welcome_lbl = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.File_mnutab = new System.Windows.Forms.ToolStripMenuItem();
            this.CreatFile_Itme = new System.Windows.Forms.ToolStripMenuItem();
            this.addtoExistingFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recommendMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Create_lbl = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome_lbl
            // 
            this.Welcome_lbl.AutoSize = true;
            this.Welcome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_lbl.Location = new System.Drawing.Point(69, 33);
            this.Welcome_lbl.Name = "Welcome_lbl";
            this.Welcome_lbl.Size = new System.Drawing.Size(596, 42);
            this.Welcome_lbl.TabIndex = 0;
            this.Welcome_lbl.Text = "Welcome to The World of Movies";
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_mnutab,
            this.themesToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(705, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "MainMenu";
            // 
            // File_mnutab
            // 
            this.File_mnutab.BackColor = System.Drawing.Color.LightGray;
            this.File_mnutab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreatFile_Itme,
            this.addtoExistingFileToolStripMenuItem,
            this.removeFromFileToolStripMenuItem,
            this.editFromFileToolStripMenuItem,
            this.searchFileToolStripMenuItem,
            this.recommendMoviesToolStripMenuItem});
            this.File_mnutab.Name = "File_mnutab";
            this.File_mnutab.Size = new System.Drawing.Size(37, 20);
            this.File_mnutab.Text = "File";
            // 
            // CreatFile_Itme
            // 
            this.CreatFile_Itme.Name = "CreatFile_Itme";
            this.CreatFile_Itme.Size = new System.Drawing.Size(183, 22);
            this.CreatFile_Itme.Text = "Create File";
            this.CreatFile_Itme.Click += new System.EventHandler(this.CreatFile_Itme_Click);
            // 
            // addtoExistingFileToolStripMenuItem
            // 
            this.addtoExistingFileToolStripMenuItem.Name = "addtoExistingFileToolStripMenuItem";
            this.addtoExistingFileToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addtoExistingFileToolStripMenuItem.Text = "Add to Existing File";
            this.addtoExistingFileToolStripMenuItem.Click += new System.EventHandler(this.addtoExistingFileToolStripMenuItem_Click);
            // 
            // removeFromFileToolStripMenuItem
            // 
            this.removeFromFileToolStripMenuItem.Name = "removeFromFileToolStripMenuItem";
            this.removeFromFileToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.removeFromFileToolStripMenuItem.Text = "Remove from File";
            this.removeFromFileToolStripMenuItem.Click += new System.EventHandler(this.removeFromFileToolStripMenuItem_Click);
            // 
            // editFromFileToolStripMenuItem
            // 
            this.editFromFileToolStripMenuItem.Name = "editFromFileToolStripMenuItem";
            this.editFromFileToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.editFromFileToolStripMenuItem.Text = "Edit from File";
            this.editFromFileToolStripMenuItem.Click += new System.EventHandler(this.editFromFileToolStripMenuItem_Click);
            // 
            // searchFileToolStripMenuItem
            // 
            this.searchFileToolStripMenuItem.Name = "searchFileToolStripMenuItem";
            this.searchFileToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.searchFileToolStripMenuItem.Text = "Search File";
            this.searchFileToolStripMenuItem.Click += new System.EventHandler(this.searchFileToolStripMenuItem_Click);
            // 
            // recommendMoviesToolStripMenuItem
            // 
            this.recommendMoviesToolStripMenuItem.Name = "recommendMoviesToolStripMenuItem";
            this.recommendMoviesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.recommendMoviesToolStripMenuItem.Text = "Recommend Movies";
            this.recommendMoviesToolStripMenuItem.Click += new System.EventHandler(this.recommendMoviesToolStripMenuItem_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // Create_lbl
            // 
            this.Create_lbl.AutoSize = true;
            this.Create_lbl.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_lbl.Location = new System.Drawing.Point(176, 104);
            this.Create_lbl.Name = "Create_lbl";
            this.Create_lbl.Size = new System.Drawing.Size(323, 75);
            this.Create_lbl.TabIndex = 2;
            this.Create_lbl.Text = "Create Your Own list of Movies\r\n    Your Own RottenTomato\r\n         Your Own IMDB" +
    "!";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 235);
            this.Controls.Add(this.Create_lbl);
            this.Controls.Add(this.Welcome_lbl);
            this.Controls.Add(this.MainMenu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.Text = "Main";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_lbl;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem File_mnutab;
        private System.Windows.Forms.ToolStripMenuItem addtoExistingFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.Label Create_lbl;
        private System.Windows.Forms.ToolStripMenuItem removeFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreatFile_Itme;
        private System.Windows.Forms.ToolStripMenuItem recommendMoviesToolStripMenuItem;
    }
}


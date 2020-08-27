using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieGuide
{
    public partial class Main : Form
    {
        public static string theme;
        Edit E;
        AddToExistFile A;
        public Main()
        {
            InitializeComponent();
            A = new AddToExistFile();
            E = new Edit();
        }
        private void addtoExistingFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = new AddToExistFile();
            A.refToMain = this;
            A.Show();
            this.Hide();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theme = "Dark";
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.MainMenu.BackColor = Color.FromArgb(45, 44, 49);
            File_mnutab.ForeColor = Color.White;
            themesToolStripMenuItem.ForeColor = Color.White;
            this.Welcome_lbl.ForeColor = Color.White;
            this.Create_lbl.ForeColor = Color.White;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theme = "Default";
            this.BackColor = Color.White;
            this.MainMenu.BackColor = Color.Gainsboro;
            this.Welcome_lbl.ForeColor = Color.Black;
            this.Create_lbl.ForeColor = Color.Black;
            File_mnutab.ForeColor = Color.Black;
            themesToolStripMenuItem.ForeColor = Color.Black;
        }

        private void editFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            E = new Edit();
            A = new AddToExistFile();
            A.refToMain = this;
            E.refToMain = this;
            E.Show();
            this.Hide();
        }

        private void removeFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove R = new Remove();
            R.Show();
        }

        private void searchFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search S = new Search();
            S.refToMain = this;
            S.Show();
            this.Hide();
        }

        private void CreatFile_Itme_Click(object sender, EventArgs e)
        {
            CreateFile C = new CreateFile();
            C.refToMain = this;
            C.Show();
            this.Hide();
        }

        private void recommendMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recommend R = new Recommend();
            R.refToMain = this;
            R.Show();
            this.Hide();
        }
    }
}

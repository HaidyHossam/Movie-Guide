using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MovieGuide
{
    public partial class Edit : Form
    {
        XmlDocument doc;
        Movie moVie = new Movie();
        string fileName;
        public AddToExistFile refToAdd { get; set; }
        public Main refToMain { get; set; }
        public Edit()
        {
            InitializeComponent();
            if (Main.theme == "Dark")
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.label1.ForeColor = Color.White;
                this.label10.ForeColor = Color.White;
                this.label2.ForeColor = Color.White;
                this.label3.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
                this.label5.ForeColor = Color.White;
                this.label6.ForeColor = Color.White;
                this.label7.ForeColor = Color.White;
                this.label8.ForeColor = Color.White;
                this.label9.ForeColor = Color.White;
            }
            else if (Main.theme == "Default")
            {
                this.BackColor = Color.White;
                this.label1.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label10.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label3.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label5.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label8.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            fileName = FileNA_TXT.Text;
            string toEdit = EMovieTitle_txt.Text;

            Movie movie = new Movie();
            movie = moVie.MovieEdit(fileName, toEdit);
            ID_txt.Text = movie.ID;
            Title_txt.Text = movie.Title;
            Director_txt.Text = movie.Director;
            Year_cmbo.Text = movie.Year;
            Rating_combo.Text = movie.Rating;
            for (int j = 0; j < movie.Genres.Count; j++)
            {
                for (int h = 0; h < Genree_lst.Items.Count; h++)
                {
                    if (movie.Genres.ElementAt(j).nameofgenre == Genree_lst.Items[h].ToString())
                    {
                        Genree_lst.SetItemChecked(h, true);
                    }
                }
            }
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            this.refToMain.Show();
            this.Hide();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            List<Genree> List = new List<Genree>();
            for (int k = 0; k < Genree_lst.CheckedItems.Count; k++)
            {
                Genree list = new Genree(Genree_lst.CheckedItems[k].ToString());
                List.Add(list);

            }
            moVie.Save_Movie(FileNA_TXT.Text, EMovieTitle_txt.Text, ID_txt.Text, Title_txt.Text, Director_txt.Text, Year_cmbo.SelectedItem.ToString(), Rating_combo.SelectedItem.ToString(), List);
            MessageBox.Show("Edited Successfully :)", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            FileNA_TXT.Clear();
            EMovieTitle_txt.Clear();
            ID_txt.Clear();
            Title_txt.Clear();
            Director_txt.Clear();
            Year_cmbo.Text = "";
            Rating_combo.Text = "";
            bool state = false;
            for (int i = 0; i < Genree_lst.Items.Count; i++)
            {
                Genree_lst.SetItemCheckState(i, (state ? CheckState.Checked : CheckState.Unchecked));
            }
        }
    }
}

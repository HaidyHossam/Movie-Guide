using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MovieGuide
{
    public partial class AddToExistFile : Form
    {
        public Main refToMain { get; set; }
        string imageLocation = "";
        public AddToExistFile()
        {
            InitializeComponent();
            RecordData_pnl.Hide();
            if(Main.theme == "Dark")
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.RecordData_pnl.BackColor = Color.FromArgb(30, 30, 30);
                this.label1.ForeColor = Color.White;
                this.label2.ForeColor = Color.White;
                this.label3.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
                this.label5.ForeColor = Color.White;
                this.label6.ForeColor = Color.White;
                this.label7.ForeColor = Color.White;
                this.label9.ForeColor = Color.White;
                
            }
            else if(Main.theme == "Default")
            {
                this.BackColor = Color.White;
                this.RecordData_pnl.BackColor = Color.White;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label3.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label5.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;

            }
        }

        private void FileOpen_btn_Click(object sender, EventArgs e)
        {
            RecordData_pnl.Show();
            string FileName = FileName_txt.Text;
            if (!File.Exists(FileName + ".xml"))
            {
                MessageBox.Show("The File Not Exist !!! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.refToMain.Show();
        }

        private void Upload_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg(|*.jpg| PNG files(*.png)|*.png| All Files(*.*(|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    Poster_pic.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please try again", "Error");
            }
        }

        private void A_add_btn_Click(object sender, EventArgs e)
        {
            Movie m = new Movie();
            string ID = ID_txt.Text;
            string FileName = FileName_txt.Text;
            if (m.SearchUniquID(ID_txt.Text, FileName_txt.Text))
            {
                string Title = Title_txt.Text;
                List<Genree> g = new List<Genree>();
                for (int i = 0; i < Genre_lst.CheckedItems.Count; i++)
                {
                    Genree ge = new Genree(Genre_lst.CheckedItems[i].ToString());
                    g.Add(ge);
                }
                string Director = Director_txt.Text;
                string Year = Year_cmbo.Text;
                string Rating = Rating_combo.Text;

                string path = imageLocation;

                m.AddToExist(ID, Title, g, Director, Year, Rating, FileName, path);
                MessageBox.Show("Added Successfully ^_^", "File", MessageBoxButtons.OK, MessageBoxIcon.None);
                FileName_txt.Clear();
                ID_txt.Clear();
                Title_txt.Clear();
                Director_txt.Clear();
                Rating_combo.Text = "";
                Year_cmbo.Text = "";
                Poster_pic.ImageLocation = "";
                bool state = false;
                for (int j = 0; j < Genre_lst.CheckedItems.Count; j++)
                {
                    Genre_lst.SetItemCheckState(j, (state ? CheckState.Checked : CheckState.Unchecked));
                }
            }
            else
            {
                MessageBox.Show("You must enter a unique ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

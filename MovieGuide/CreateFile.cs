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
    public partial class CreateFile : Form
    {
        List<string> Files = new List<string>();
        public Main refToMain { get; set; }
        string imageLocation = "";
        public CreateFile()
        {
            InitializeComponent();
            RecordData_pnl.Hide();
            if (File.Exists("Files.txt"))
            {
                FileStream fs = new FileStream("Files.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                while (sr.Peek() != -1)
                {
                    Files.Add(sr.ReadLine());
                }
                sr.Close();
                fs.Close();
            }
            if (Main.theme == "Dark")
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
            else if (Main.theme == "Default")
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void FileCreate_btn_Click(object sender, EventArgs e)
        {
            RecordData_pnl.Show();
            RecordData_pnl.Show();
            FileStream fs = new FileStream("Files.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(FileName_txt.Text);
            sw.Close();
            fs.Close();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            this.refToMain.Show();
            this.Hide();
            
        }

        private void C_Add_btn_Click(object sender, EventArgs e)
        {
            Movie m = new Movie();
            string ID = ID_txt.Text;
            string Title = Title_txt.Text;
            List<Genree> g = new List<Genree>();
            for (int i = 0; i < Genre_lst.CheckedItems.Count; i++)
            {
                Genree ge = new Genree(Genre_lst.CheckedItems[i].ToString());

                g.Add(ge);
            } 
            string Year = Year_cmbo.Text;
            string Rating = Rating_combo.Text;
            string Director = Director_txt.Text;
            string FileName = FileName_txt.Text;
            string path = imageLocation;
            m.AddCreateFile(ID, Title, g, Director, Year, Rating, FileName, path);
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
    }
}

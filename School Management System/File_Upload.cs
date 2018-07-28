using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class File_Upload : Form
    {
        string username = null;
        string dest = null;
        string name = null;
        public File_Upload(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = open.FileName;
                string[] f = file.Split('\\');
                string fn = f[(f.Length) - 1];
                dest = @"G:\File\" + fn;
                name = dest.Substring(8);
                textBox1.Text = name;
                File.Copy(file, dest, true);
            }
        }

        private void File_Upload_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher_Dashboard teacher = new Teacher_Dashboard(username);
            teacher.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                db.UploadFile(username, name, dest);
            }
            catch(Exception ee)
            {
                MessageBox.Show("Choose a file first");
            }
        }
    }
}

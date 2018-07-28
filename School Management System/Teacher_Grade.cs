using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Teacher_Grade : Form
    {
        string username = null;
        public Teacher_Grade(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void Teacher_Grade_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Teacher_Dashboard teacher = new Teacher_Dashboard(username);
            teacher.Show();
            this.Hide();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                btnSubmit.Enabled = true;
                comboBox1.SelectedIndex = comboBox.SelectedIndex;
                DatabaseManager db = new DatabaseManager();
                dataGridView1.DataSource = db.getGrade(comboBox1.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Data Retrieve Error");
            }
        }

        private void Teacher_Grade_Load(object sender, EventArgs e)
        {
            DatabaseManager db = new DatabaseManager();
            string teacherName = db.getFacultyName(username);
            object list = db.getFacultyCourse(teacherName);
            comboBox.DisplayMember = "Name";
            comboBox.DataSource = list;
            comboBox1.DisplayMember = "ID";
            comboBox1.DataSource = list;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                db.UploadGrade(dataGridView1);
                MessageBox.Show("GRade Submission Successful");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Submission Error");
            }
        }
    }
}

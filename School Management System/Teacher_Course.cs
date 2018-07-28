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
    public partial class Teacher_Course : Form
    {
        string username = null;
        public Teacher_Course(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Teacher_Dashboard teacher = new Teacher_Dashboard(username);
            teacher.Show();
            this.Hide();
        }

        private void Teacher_Course_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Teacher_Course_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                string teacherName = db.getFacultyName(username);
                object list = db.getFacultyCourse(teacherName);
                dataGridView1.DataSource = list;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Data Retrieve Error");
            }
        }
    }
}

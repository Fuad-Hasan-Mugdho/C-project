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
    public partial class Teacher_Dashboard : Form
    {
        string Username = null;
        public Teacher_Dashboard(string Username)
        {
            this.Username = Username;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Teacher_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Teacher_Profile profile = new Teacher_Profile(Username);
            profile.Show();
            this.Hide();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            Teacher_Course course = new Teacher_Course(Username);
            course.Show();
            this.Hide();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            Teacher_Grade grade = new Teacher_Grade(Username);
            grade.Show();
            this.Hide();
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            Teacher_Notice notice = new Teacher_Notice(Username);
            notice.Show();
            this.Hide();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            Student_Notice file = new Student_Notice("");
            file.Show();
            this.Hide();
        }

        private void Teacher_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File_Upload file = new File_Upload(Username);
            file.Show();
            this.Hide();
        }
    }
}

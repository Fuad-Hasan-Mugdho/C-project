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
    public partial class Student_Dashboard : Form
    {
        string username = null;
        public Student_Dashboard(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Student_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            Student_Grade grade = new Student_Grade(username);
            grade.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Student_Profile profile = new Student_Profile(username);
            profile.Show();
            this.Hide();
        }

        private void Student_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            Student_Notice profile = new Student_Notice(username);
            profile.Show();
            this.Hide();
        }
    }
}

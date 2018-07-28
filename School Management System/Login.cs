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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin = new Admin_Dashboard();
            admin.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            DatabaseManager db = new DatabaseManager();
            string check=db.checkLogin(txtUsername.Text, txtPassword.Text);
            switch(check)
            {
                case "Admin":
                    Admin_Dashboard admin = new Admin_Dashboard();
                    admin.Show();
                    MessageBox.Show("Welcome  Administrator ", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    break;

                case "Student":
                    Student_Dashboard student = new Student_Dashboard(txtUsername.Text);
                    student.Show();
                    MessageBox.Show("Welcome  Student ", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    break;

                case "Teacher":
                    Teacher_Dashboard teacher = new Teacher_Dashboard(txtUsername.Text);
                    teacher.Show();
                    MessageBox.Show("Welcome  Faculty ", "Faculty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    break;
            }

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
    }
}

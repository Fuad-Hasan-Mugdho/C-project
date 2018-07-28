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
    public partial class Student_Profile : Form
    {
        string username = null;
        public Student_Profile(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void Student_Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student_Dashboard dashboard = new Student_Dashboard(username);
            dashboard.Show();
            this.Hide();
        }

        private void Student_Profile_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager dm = new DatabaseManager();
                string[] student = dm.FindStudent(username);
                txtID.Text = student[0];
                txtName.Text = student[1];
                txtPassword.Text = student[2];
                if (student[3] == "Male")
                {
                    radioMale.Checked = true;

                }
                else
                {
                    radioFemale.Checked = true;
                }

                BGBox.Text = student[4];
                datePicker.Value = Convert.ToDateTime(student[5]);
                DepartmentBox.Text = student[6];
                txtCGPA.Text = student[7];
                txtGuardian.Text = student[8];
                txtContact.Text = student[9];
                txtEmail.Text = student[10];
                txtAddress.Text = student[11];
                pictureBox.Image = Image.FromFile(student[12]);
            }
            catch(Exception ee)
            {
                MessageBox.Show("Data Retrieve Error");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

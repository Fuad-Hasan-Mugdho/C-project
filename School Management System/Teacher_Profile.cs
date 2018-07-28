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
    public partial class Teacher_Profile : Form
    {
        string username;
        public Teacher_Profile(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void Teacher_Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Teacher_Dashboard teacher = new Teacher_Dashboard(username);
            teacher.Show();
            this.Hide();
        }

        private void Teacher_Profile_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager dm = new DatabaseManager();
                string[] student = dm.FindFaculty(username);
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
                txtContact.Text = student[7];
                txtEmail.Text = student[8];
                txtAddress.Text = student[9];
                pictureBox.Image = Image.FromFile(student[10]);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Data Retrieve Error");
            }
        }
    }
}

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
    public partial class Search_Faculty : Form
    {
        string picURL = null;
        public Search_Faculty()
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label10.Hide();
            label12.Hide();
            label13.Hide();
            btnEdit.Hide();
            btnDone.Hide();
            btnDelete.Hide();
            txtID.Hide();
            txtName.Hide();
            txtPassword.Hide();
            txtAddress.Hide();
            txtContact.Hide();
            txtEmail.Hide();
            radioFemale.Hide();
            radioMale.Hide();
            BGBox.Hide();
            DepartmentBox.Hide();
            datePicker.Hide();
            pictureBox.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin = new Admin_Dashboard();
            admin.Show();
            this.Hide();
        }

        private void Search_Faculty_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            btnDone.Hide();
            btnEdit.Show();
            txtName.Enabled = false;
            txtPassword.Enabled = false;
            txtAddress.Enabled = false;
            txtContact.Enabled = false;
            txtEmail.Enabled = false;
            radioFemale.Enabled = false;
            radioMale.Enabled = false;
            BGBox.Enabled = false;
            DepartmentBox.Enabled = false;
            datePicker.Enabled = false; string gender = null;
            if (radioFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }

            DatabaseManager db = new DatabaseManager();
            db.Update_Faculty(txtID.Text, txtName.Text, txtPassword.Text, gender, BGBox.Text, datePicker.Text, DepartmentBox.Text, txtContact.Text, txtEmail.Text, txtAddress.Text, picURL);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Hide();
            btnDone.Show();
            txtName.Enabled = true;
            txtPassword.Enabled = true;
            txtAddress.Enabled = true;
            txtContact.Enabled = true;
            txtEmail.Enabled = true;
            radioFemale.Enabled = true;
            radioMale.Enabled = true;
            BGBox.Enabled = true;
            DepartmentBox.Enabled = true;
            datePicker.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager dm = new DatabaseManager();
                string[] student = dm.FindFaculty(searchBox.Text);
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
                picURL = student[10];
                label14.Hide();
                searchBox.Hide();
                btnSearch.Hide();
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label10.Show();
                label12.Show();
                label13.Show();
                btnEdit.Show();
                btnDelete.Show();
                btnBack.Location = new Point(440, 319);
                txtID.Show();
                txtName.Show();
                txtPassword.Show();
                txtAddress.Show();
                txtContact.Show();
                txtEmail.Show();
                radioFemale.Show();
                radioMale.Show();
                BGBox.Show();
                DepartmentBox.Show();
                datePicker.Show();
                pictureBox.Show();


               
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                db.deleteFaculty(txtID.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Delete Error");
            }
        }
    }
}

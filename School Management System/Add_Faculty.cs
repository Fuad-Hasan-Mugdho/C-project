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
    public partial class Add_Faculty : Form
    {
        string picturePath = null;
        public Add_Faculty()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            BGBox.Text = "A+";
            DepartmentBox.Text = "CSE";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            radioMale.Checked = false;
            radioFemale.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin = new Admin_Dashboard();
            admin.Show();
            this.Hide();
        }

        private void Add_Faculty_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picturePath = file.FileName;
                pictureBox.Image = Image.FromFile(picturePath);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                string gender = null;
                if (radioFemale.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }
                db.Add_Faculty(txtID.Text, txtName.Text, txtPassword.Text, gender, BGBox.Text, datePicker.Text, DepartmentBox.Text, txtContact.Text, txtEmail.Text, txtAddress.Text, picturePath);
                txtID.Text = null;
                txtName.Text = null;
                txtPassword.Text = null;
                gender = null;
                BGBox.Text = null;
                DepartmentBox.Text = null;
                txtContact.Text = null;
                txtEmail.Text = null;
                txtAddress.Text = null;
                picturePath = null;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Fill all the field correctly");
            }
        }
    }
}

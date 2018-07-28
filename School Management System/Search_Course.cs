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
    public partial class Search_Course : Form
    {
        public Search_Course()
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            txtID.Hide();
            txtName.Hide();
            TeacherBox.Hide();
            DepartmentBox.Hide();
            btnEdit.Hide();
            btnEdit.Hide();
            btnDelete.Hide();
            btnDone.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin = new Admin_Dashboard();
            admin.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                string[] array = db.FindCourse(searchBox.Text);

                txtID.Text = array[0];
                txtName.Text = array[1];
                TeacherBox.Text = array[2];
                DepartmentBox.Text = array[3];

                label14.Hide();
                searchBox.Hide();
                btnSearch.Hide();

                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                txtID.Show();
                txtName.Show();
                TeacherBox.Show();
                DepartmentBox.Show();
                btnEdit.Show();
                btnDelete.Show();
                btnBack.Location = new Point(37, 252);

                DepartmentBox.Text = "Department Name";

            }
            catch (Exception ee)
            {
                MessageBox.Show("Data Retrieve Error");
            }
        }

        private void Search_Course_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                btnEdit.Show();
                btnDone.Hide();
                txtName.Enabled = false;
                TeacherBox.Enabled = false;
                DepartmentBox.Enabled = false;

                DatabaseManager db = new DatabaseManager();
                db.Update_Course(txtID.Text, txtName.Text, TeacherBox.Text, DepartmentBox.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Update Error");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Hide();
            btnDone.Show();
            txtName.Enabled = true;
            TeacherBox.Enabled = true;
            DepartmentBox.Enabled = true;
        }

        private void Search_Course_Load(object sender, EventArgs e)
        {
            DatabaseManager db = new DatabaseManager();
            IList<Teacher> a = db.teacherName();
            TeacherBox.DisplayMember = "Name";
            TeacherBox.DataSource = a;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                db.deleteCourse(txtID.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Delete Error");
            }
        }
    }
}

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
    public partial class Add_Course : Form
    {
        public Add_Course()
        {
            InitializeComponent();
            TeacherBox.SelectedIndex = 0;
            DepartmentBox.SelectedIndex = 0;
            txtID.Text = null;
            txtName.Text = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            TeacherBox.Text = "Teacher Name";
            DepartmentBox.Text = "Department Name";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin = new Admin_Dashboard();
            admin.Show();
            this.Hide();
        }

        private void Add_Course_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                db.AddCourse(txtID.Text, txtName.Text, TeacherBox.Text, DepartmentBox.Text);
                txtID.Text = null;
                txtName.Text = null;
                TeacherBox.Text = null;
                DepartmentBox.Text = null;
            }
            catch(Exception ee)
            {
                MessageBox.Show("Fill all the fields Correctly");
            }
        }

        private void Add_Course_Load(object sender, EventArgs e)
        {
            DatabaseManager db = new DatabaseManager();
            IList<Teacher> a = db.teacherName();
            TeacherBox.DisplayMember = "Name";
            TeacherBox.DataSource = a;
        }
    }
}

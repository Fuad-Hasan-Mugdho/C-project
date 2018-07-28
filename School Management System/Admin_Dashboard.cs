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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Admin_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void btnSearchSTD_Click(object sender, EventArgs e)
        {
            Search_Student search = new Search_Student();
            search.Show();
            this.Hide();
        }

        private void btnSearchTCR_Click(object sender, EventArgs e)
        {
            Search_Faculty teacher = new Search_Faculty();
            teacher.Show();
            this.Hide();
        }

        private void btnAddCRS_Click(object sender, EventArgs e)
        {
            Add_Course course = new Add_Course();
            course.Show();
            this.Hide();
        }

        private void btnSearchCRS_Click(object sender, EventArgs e)
        {
            Search_Course search = new Search_Course();
            search.Show();
            this.Hide();
        }

        private void btnSTDReg_Click(object sender, EventArgs e)
        {
            Student_Registration student = new Student_Registration();
            student.Show();
            this.Hide();
        }
        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnAddSTD_Click(object sender, EventArgs e)
        {
            Add_Student student = new Add_Student();
            student.Show();
            this.Hide();
        }

        private void btnAddTCR_Click(object sender, EventArgs e)
        {
            Add_Faculty faculty = new Add_Faculty();
            faculty.Show();
            this.Hide();
        }
    }
}

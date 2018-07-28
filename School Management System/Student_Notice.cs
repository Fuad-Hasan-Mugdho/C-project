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
    public partial class Student_Notice : Form
    {
        string username = null;
        public Student_Notice(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student_Dashboard dashboard = new Student_Dashboard(username);
            dashboard.Show();
            this.Hide();
        }

        private void Student_Notice_Load(object sender, EventArgs e)
        {
            DatabaseManager db = new DatabaseManager();
            object course = db.StudentCourse(username);
            comboBox.DisplayMember = "Course_ID";
            comboBox.DataSource = course;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                MessageBox.Show(db.getNoticeDetails(comboBox1.SelectedValue.ToString()));
            }
            catch (Exception ee)
            {
                MessageBox.Show("Fill all the field correctly");
            }
        }

        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DatabaseManager db = new DatabaseManager();
            object course = db.getNoticeList(comboBox.Text);
            comboBox1.DisplayMember = "Subject";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = course;
        }

        private void Student_Notice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

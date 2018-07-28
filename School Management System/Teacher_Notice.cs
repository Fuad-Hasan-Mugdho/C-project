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
    public partial class Teacher_Notice : Form
    {
        string username = null;
        public Teacher_Notice(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Teacher_Dashboard teacher = new Teacher_Dashboard(username);
            teacher.Show();
            this.Hide();
        }

        private void Teacher_Notice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtDetails.Enabled = true;
        }

        private void Teacher_Notice_Load(object sender, EventArgs e)
        {
            DatabaseManager db = new DatabaseManager();
            string teacherName = db.getFacultyName(username);
            object list = db.getFacultyCourse(teacherName);
            comboBox.DisplayMember = "Name";
            comboBox.DataSource = list;
            comboBox.ValueMember = "ID";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                db.SubmitNotice(username, comboBox.SelectedValue.ToString(), txtSubject.Text, txtDetails.Text);
                MessageBox.Show("Notice Published");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Fill all the fields correctly");
            }
        }

        private void txtDetails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Student_Grade : Form
    {
        string destination = null;
        public Student_Grade(string from)
        {
            destination = from;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student_Dashboard student = new Student_Dashboard(destination);
            student.Show();
            this.Hide();
        }

        private void Studetn_Grade_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Studetn_Grade_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                dataGridView1.DataSource = db.getGrades(destination);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Data Retrieve Error");
            }
        }
    }
}

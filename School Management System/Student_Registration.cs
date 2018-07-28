using System;
using System.Collections;
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
    public partial class Student_Registration : Form
    {
        DataTable table = new DataTable();

        public Student_Registration()
        {
            InitializeComponent();
            table.Columns.Add("Student ID", typeof(string));
            table.Columns.Add("Course ID", typeof(string));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin = new Admin_Dashboard();
            admin.Show();
            this.Hide();
        }

        private void Student_Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                db.UploadRegistration(dataGridView);
                MessageBox.Show("Registration Successful");
            }
            catch(Exception ee)
            {
                MessageBox.Show("Fill all the fields correctly");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null || textBox1.Text != "")
            {
                table.Rows.Add(textBox1.Text, comboBox2.Text);
                dataGridView.DataSource = table;
            }
            else
            {
                MessageBox.Show("Please select student ID");
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Student_Registration_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Enabled = true;
                btnAdd.Enabled = true;
                DatabaseManager db = new DatabaseManager();

                IList<Course> course = db.getCourseName();

                comboBox1.DisplayMember = "Name";
                comboBox1.DataSource = course;
                comboBox2.DisplayMember = "ID";
                comboBox2.DataSource = course;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Fill all the fields correctly");
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox2.Text = comboBox1.Text;
        }
    }
}

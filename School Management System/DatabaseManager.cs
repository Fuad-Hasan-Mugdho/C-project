using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    class DatabaseManager
    {
        StudentDataContextDataContext cd = new StudentDataContextDataContext(); 
        public void Add_Student(string id, string name, string pass, string gender, string bg, string dob, string department, string cgpa, string gurdian, string contact, string email, string address, string picpath)
        {
                Student s = new Student();
                s.ID = id;
                s.Name = name;
                s.Password = pass;
                s.Gender = gender;
                s.BG = bg;
                s.DOB = dob;
                s.Department = department;
                s.CGPA = cgpa;
                s.Gurdian = gurdian;
                s.Contact = contact;
                s.Email = email;
                s.Address = address;
                s.Picturepath = picpath;

                cd.Students.InsertOnSubmit(s);
                cd.SubmitChanges();
                addStudentStatus(id, pass, "Student");  
                MessageBox.Show("Student Added");

        }

        public void Add_Faculty(String id, string name, string pass, string gender, string bg, string dob, string department, string contact, string email, string address, string picpath)
        {
                Teacher s = new Teacher();
                s.ID = id;
                s.Name = name;
                s.Password = pass;
                s.Gender = gender;
                s.BG = bg;
                s.DOB = dob;
                s.Department = department;
                s.Contact = contact;
                s.Email = email;
                s.Address = address;
                s.PicturePath = picpath;
                cd.Teachers.InsertOnSubmit(s);
                cd.SubmitChanges();
                addStudentStatus(id, pass, "Teacher");
                MessageBox.Show("Teacher Added");

        }


        public void AddCourse(String id, string name, string teacher, string department)
        {
            Course s = new Course();
            s.ID = id;
            s.Name = name;
            s.Teacher = teacher;
            s.Department = department;
            cd.Courses.InsertOnSubmit(s);
            cd.SubmitChanges();
            MessageBox.Show("Course Added");
        }

        //update student information
        public void Update_Student(String id, string name, string pass, string gender, string bg, string dob, string department, string cgpa, string gurdian, string contact, string email, string address)
        {
            Student s = cd.Students.Single(Student => Student.ID == id);
            try
            {

                s.ID = id;
                s.Name = name;
                s.Password = pass;
                s.Gender = gender;
                s.BG = bg;
                s.DOB = dob;
                s.Department = department;
                s.CGPA = cgpa;
                s.Gurdian = gurdian;
                s.Contact = contact;
                s.Email = email;
                s.Address = address;

                cd.SubmitChanges();

                MessageBox.Show("Student Updated");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }
        public void Update_Faculty(String id, string name, string pass, string gender, string bg, string dob, string department, string contact, string email, string address, string pic)
        {
            Teacher teacher = cd.Teachers.Single(Student => Student.ID == id);
            try
            {

                teacher.ID = id;
                teacher.Name = name;
                teacher.Password = pass;
                teacher.Gender = gender;
                teacher.BG = bg;
                teacher.DOB = dob;
                teacher.Department = department;
                teacher.Contact = contact;
                teacher.Email = email;
                teacher.Address = address;
                teacher.PicturePath = pic;

                cd.SubmitChanges();

                MessageBox.Show("Teacher Updated");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        public void addStudentStatus(string id, string pass, string type)
        {
            try
            {
                LoginInfo l = new LoginInfo();
                l.ID = id;
                l.Password = pass;
                l.Type = type;
                cd.LoginInfos.InsertOnSubmit(l);
                cd.SubmitChanges();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        public String checkLogin(string username, string pass)
        {
            try
            {
                LoginInfo l = cd.LoginInfos.Single(LoginInfo => LoginInfo.ID == username && LoginInfo.Password == pass);
                if (l != null)
                {
                    return l.Type;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Invalid Username or Password ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return "";
            }
            return "";
        }
        public void deleteStudent(string id)
        {
            Student student = cd.Students.SingleOrDefault(x => x.ID == id);
            try
            {
                cd.Students.DeleteOnSubmit(student);
                cd.SubmitChanges();
                MessageBox.Show("Student Deleted Successfully");
                LoginInfo log = cd.LoginInfos.SingleOrDefault(x => x.ID == id);

                cd.LoginInfos.DeleteOnSubmit(log);
                cd.SubmitChanges();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }


        public void deleteFaculty(string id)
        {
            Teacher teacher = cd.Teachers.SingleOrDefault(x => x.ID == id);
            try
            {
                cd.Teachers.DeleteOnSubmit(teacher);
                cd.SubmitChanges();
                MessageBox.Show("Teacher Deleted Successfully");

                LoginInfo log = cd.LoginInfos.SingleOrDefault(x => x.ID == id);

                cd.LoginInfos.DeleteOnSubmit(log);
                cd.SubmitChanges();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public string[] FindStudent(string id)
        {
            try
            {
                Student student = cd.Students.SingleOrDefault(x => x.ID == id);  //SingleOrDefault -> single row return 
                if (student != null)
                {
                    string[] array = new string[13];
                    array[0] = student.ID;
                    array[1] = student.Name;
                    array[2] = student.Password;
                    array[3] = student.Gender;
                    array[4] = student.BG;
                    array[5] = student.DOB;
                    array[6] = student.Department;
                    array[7] = student.CGPA.ToString();
                    array[8] = student.Gurdian;
                    array[9] = student.Contact;
                    array[10] = student.Email;
                    array[11] = student.Address;
                    array[12] = student.Picturepath;
                    return array;
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            return null;
        }

        public string[] FindFaculty(string id)
        {
            try
            {
                Teacher teacher = cd.Teachers.SingleOrDefault(x => x.ID == id);
                if (teacher != null)
                {
                    string[] array = new string[11];
                    array[0] = teacher.ID;
                    array[1] = teacher.Name;
                    array[2] = teacher.Password;
                    array[3] = teacher.Gender;
                    array[4] = teacher.BG;
                    array[5] = teacher.DOB;
                    array[6] = teacher.Department;
                    array[7] = teacher.Contact;
                    array[8] = teacher.Email;
                    array[9] = teacher.Address;
                    array[10] = teacher.PicturePath;
                    return array;
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            return null;
        }

        public string[] FindCourse(string id)
        {
            Course course = cd.Courses.SingleOrDefault(x => x.ID == id);
            if (course != null)
            {
                string[] array = new string[11];
                array[0] = course.ID;
                array[1] = course.Name;
                array[2] = course.Teacher;
                array[3] = course.Department;
                return array;
            }
            return null;
        }


        public IList<Teacher> teacherName()
        {
            //Student student = cd.Students.SingleOrDefault(x => x.CGPA == -1);
            List<Teacher> t = cd.Teachers.ToList<Teacher>();
            return t;
        }

        public void Update_Course(String id, string name, string teacher, string department)
        {
            Course course = cd.Courses.Single(Student => Student.ID == id);
            try
            {

                course.ID = id;
                course.Name = name;
                course.Teacher = teacher;
                course.Department = department;

                cd.SubmitChanges();

                MessageBox.Show("Course Updated");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        public void deleteCourse(string id)
        {
            Course course = cd.Courses.SingleOrDefault(x => x.ID == id);
            try
            {
                cd.Courses.DeleteOnSubmit(course);
                cd.SubmitChanges();
                MessageBox.Show("Course Deleted Successfully");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }


        public object getFacultyCourse(string teacher)
        {
            var ListofUsers = from crs in cd.Courses
                              where crs.Teacher == teacher
                              select crs;

            return ListofUsers;
        }

        public string getFacultyName(string id)
        {
            try
            {
                Teacher teacher = cd.Teachers.SingleOrDefault(x => x.ID == id);
                if (teacher != null)
                {
                    return teacher.Name;
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            return null;
        }

        public IList<Course> getCourseName()
        {
            List<Course> course = cd.Courses.ToList<Course>();
            return course;
        }

        public object getTeacherCourse(string id)
        {
            var course = from c in cd.Courses
                         where c.Teacher == id
                         select c;
            return course;
        }

        public void UploadRegistration(DataGridView data)
        {
            DataTable dt = (DataTable)data.DataSource;
            foreach (DataRow dr in dt.Rows)
            {
                string stdID = dr["Student ID"].ToString();
                string crsID = dr["Course ID"].ToString();

                uploadRow(stdID, crsID);
            }
        }

        public void uploadRow(string student, string course)
        {
            try
            {
                Registration reg = new Registration();
                reg.Student_ID = student;
                reg.Course_ID = course;
                cd.Registrations.InsertOnSubmit(reg);
                cd.SubmitChanges();

                Grade grade = new Grade();
                grade.Course = course;
                grade.Student = student;
                grade.Marks = "";
                cd.Grades.InsertOnSubmit(grade);
                cd.SubmitChanges();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public object getGrades(string id)
        {
            var data = from value in cd.Grades
                       where value.Student == id
                       select new { value.Course,value.Student,value.Marks,value.Result};
            return data;
        }


        public object getGrade(string id)
        {
            var data = from value in cd.Grades
                       where value.Course == id
                       select value;
            return data;
        }

        public void UploadGrade(DataGridView data)
        {
            try
            {
                foreach (DataGridViewRow dr in data.Rows)
                {
                    if (dr != null)
                    {
                        string crsID = dr.Cells[1].Value.ToString();
                        string stdID = dr.Cells[2].Value.ToString();
                        string marks = dr.Cells[3].Value.ToString();

                        Grade grade = cd.Grades.SingleOrDefault(x => x.Course == crsID && x.Student == stdID);

                        grade.Course = crsID;
                        grade.Student = stdID;
                        grade.Marks = marks;
                        try
                        {
                            grade.Result = getResult(int.Parse(marks));
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(ee.Message);
                        }
                        cd.SubmitChanges();
                    }
                }
            }
            catch(Exception ee)
            {
                //MessageBox.Show(ee.Message);
            }
        }

        public string getResult(int marks)
        {
            if (marks < 50)
            {
                return "F";
            }
            else if (marks >= 50 && marks < 54)
            {
                return "D-";
            }
            else if (marks >= 54 && marks < 58)
            {
                return "D";
            }
            else if (marks >= 58 && marks < 62)
            {
                return "D+";
            }
            else if (marks >= 62 && marks < 66)
            {
                return "C-";
            }
            else if (marks >= 66 && marks < 70)
            {
                return "C";
            }
            else if (marks >= 70 && marks < 74)
            {
                return "C+";
            }
            else if (marks >= 74 && marks < 78)
            {
                return "B-";
            }
            else if (marks >= 78 && marks < 82)
            {
                return "B";
            }
            else if (marks >= 82 && marks < 86)
            {
                return "B+";
            }
            else if (marks >= 86 && marks < 90)
            {
                return "A-";
            }
            else if (marks >= 90 && marks < 94)
            {
                return "A";
            }
            else if (marks >= 94 && marks <= 100)
            {
                return "A+";
            }
            else
            {
                return "-";
            }
        }

        public void SubmitNotice(string teacherID,string courseID,string subject,string details)
        {
            Notice notice = new Notice();
            notice.CourseID = courseID;
            notice.TeacherID = teacherID;
            notice.Subject = subject;
            notice.Details = details;

            cd.Notices.InsertOnSubmit(notice);
            cd.SubmitChanges();
        }

        public object StudentCourse(string id)
        {
            var course = from c in cd.Registrations
                         where c.Student_ID == id
                         select c;
            return course;
        }


        public object getNoticeList(string id)
        {
            var course = from c in cd.Notices
                         where c.CourseID == id
                         select c;
            return course;
        }
        public string getNoticeDetails(string id)
        {
            Notice details = cd.Notices.SingleOrDefault(x => x.Id == int.Parse(id));
            return details.Details;
        }
        public void UploadFile(string id,string name,string loc)
        {
            Note note = new Note();
            note.Name = name;
            note.Location = loc;
            note.Teacher = id;

            cd.Notes.InsertOnSubmit(note);
            cd.SubmitChanges();

            MessageBox.Show("File Uploaded");
        }
        
        public int getStudentCount()
        {
            var student = from std in cd.Students
                          select std;
            return student.Count();
        }
    }
}

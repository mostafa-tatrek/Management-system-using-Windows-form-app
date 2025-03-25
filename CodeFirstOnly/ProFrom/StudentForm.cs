using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirstOnly.Context;
using CodeFirstOnly.Models;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProFrom
{
    public partial class StudentForm : Form
    {
        proContext db = new proContext();

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            db.Students.Load();
            db.Courses.Load();
            View1.Refresh();

            

            comboCourse.DataSource = db.Courses.Local.ToBindingList();
            comboCourse.DisplayMember = "Name";
            comboCourse.ValueMember = "CourseId";

            comboStudent.DataSource = db.Students.Local.ToBindingList();
            comboStudent.DisplayMember = "FirstName";
            comboStudent.ValueMember = "StudentId";
        
            var students = db.Students.Local.Select(s => new
            {
                s.StudentId,
                FullName = s.FName + " " + s.LName,
                s.Phone,
                Courses = s.Courses.Any()
                    ? string.Join(", ", s.Courses.Select(cs => cs.Name))
                    : "No Courses"
            }).ToList();

            View1.DataSource = students;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            View1.EndEdit();
            db.SaveChanges();
        }

        private void comboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboStudent.SelectedValue == null || comboStudent.SelectedValue is not int)
                return;

            int studentId = Convert.ToInt32(comboStudent.SelectedValue);
            var student = db.Students.FirstOrDefault(s => s.StudentId == studentId);

            if (student != null)
            {
                txtFirstName.Text = student.FName;
                txtLastName.Text = student.LName;
                txtPhone.Text = student.Phone;
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student
                {
                    FName = txtFirstName.Text,
                    LName = txtLastName.Text,
                    Phone = txtPhone.Text
                };

                db.Students.Add(student);
                View1.Refresh();
               


                MessageBox.Show("Student added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (comboStudent.SelectedValue == null || comboStudent.SelectedValue is not int)
                return;

            int studentId = Convert.ToInt32(comboStudent.SelectedValue);
            var student = db.Students.FirstOrDefault(s => s.StudentId == studentId);

            try
            {
                if (student != null)
                {
                    student.FName = txtFirstName.Text;
                    student.LName = txtLastName.Text;
                    student.Phone = txtPhone.Text;

                    View1.Refresh();
                    comboStudent.DataSource = null;
                    comboStudent.DataSource = db.Students.Local.ToBindingList();
                    comboStudent.DisplayMember = "FName";
                    comboStudent.ValueMember = "StudentId";
                    MessageBox.Show("Student updated successfully.");
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboStudent.SelectedValue == null || comboStudent.SelectedValue is not int)
                return;

            int studentId = Convert.ToInt32(comboStudent.SelectedValue);
            var student = db.Students.FirstOrDefault(s => s.StudentId == studentId);

            try
            {
                if (student != null)
                {
                    db.Students.Remove(student);
                    View1.Refresh();

                    MessageBox.Show("Student deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void btnAddCourseToStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboStudent.SelectedValue == null || comboStudent.SelectedValue is not int)
                {
                    MessageBox.Show("Please select a valid student.");
                    return;
                }

                int studentId = Convert.ToInt32(comboStudent.SelectedValue);
                var student = db.Students.Include(s => s.Courses).FirstOrDefault(s => s.StudentId == studentId);
                var course = db.Courses.FirstOrDefault(c => c.CourseId == (int)comboCourse.SelectedValue);

                if (student != null && course != null)
                {
                    student.Courses.Add(course);
                    db.SaveChanges();

                    MessageBox.Show("Course added to student successfully.");
                }
                else
                {
                    MessageBox.Show("Student or Course not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



    }
}

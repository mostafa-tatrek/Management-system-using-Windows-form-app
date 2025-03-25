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
    public partial class Course : Form
    {
        proContext db = new proContext();

        public Course()
        {
            InitializeComponent();
        }
        private void Load_Click(object sender, EventArgs e)
        {
            db.Instructors.Load();
            db.Departments.Load();
            db.Courses.Load();
            View1.Refresh();
            var Courses = db.Courses.Local.Select(c => new
            {
                c.CourseId,
                FullName = c.Name,
                c.Duration,
                Departmentid = c.DeptId,
                DepartmentName = c.Department != null ? c.Department.Name : "No Department",
                Instructorid = c.InstId,
                InstructorName = c.Instructor != null ? c.Instructor.FName: "No Instructor"

            }).ToList();
            View1.DataSource = Courses;
            comboBox1.DataSource = db.Courses.Local.ToBindingList();
            comboBox1.DisplayMember = "Name";
            comboBox1.DisplayMember = "CourseId";
            comboBoxinst.DataSource = db.Instructors.Local.ToBindingList();
            comboBoxinst.DisplayMember = "FName";
            comboBoxinst.ValueMember = "InstructorId";
            comboDept.DataSource = db.Departments.Local.ToBindingList();
            comboDept.DisplayMember = "Name";
            comboDept.ValueMember = "DepartmentId";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            View1.EndEdit();
            db.SaveChanges();

        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox1.SelectedValue is not int)
            {
                return;
            }
            try
            {
                if (int.TryParse(comboBox1.SelectedValue.ToString(), out int CourseId))
                {
                    var Course = db.Courses.FirstOrDefault(c=> c.CourseId == CourseId);

                    if (Course != null)
                    {
                        name.Text = Course.Name;
                        duration.Text = Convert.ToString(Course.Duration);
                        comboDept.SelectedValue = Course.DeptId;
                        comboBoxinst.SelectedValue = Course.InstId;



                    }
                    else
                    {
                        MessageBox.Show("The course was not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void update_Click(object sender, EventArgs e)
        {
            int CourseId = Convert.ToInt32(comboBox1.SelectedValue);

            var course = db.Courses.FirstOrDefault(c => c.CourseId == CourseId);

            try
            {
                if (course != null)
                {
                    course.Name = name.Text;
                   course.Duration = Convert.ToInt32(duration.Text);
                    course.DeptId = Convert.ToInt32(comboDept.SelectedValue);
                    course.InstId= Convert.ToInt32(comboBoxinst.SelectedValue);


                    View1.Refresh();
                    comboBox1.DataSource = null;
                    comboBox1.DataSource = db.Courses.Local.ToBindingList();
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "courseid";

                }
                else
                {
                    MessageBox.Show("The course was not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var newCourse = new CodeFirstOnly.Models.Course
                {
                    Name = name.Text,
                    Duration = Convert.ToInt32(duration.Text),
                    DeptId = Convert.ToInt32(comboDept.SelectedValue),
                    InstId = Convert.ToInt32(comboBoxinst.SelectedValue)
                };

                db.Courses.Add(newCourse);
                MessageBox.Show("Course added successfully.");
                View1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding course: {ex.Message}");
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue == null || comboBox1.SelectedValue is not int)
                {
                    MessageBox.Show("Please select a course to delete.");
                    return;
                }

                int CourseId = Convert.ToInt32(comboBox1.SelectedValue);
                var course = db.Courses.FirstOrDefault(c => c.CourseId == CourseId);

                if (course != null)
                {
                    db.Courses.Remove(course);
                    db.SaveChanges();

                    MessageBox.Show("Course deleted successfully.");

                    View1.Refresh();
                }
                else
                {
                    MessageBox.Show("The course was not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting course: {ex.Message}");
            }

        }
    }
}

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
using Microsoft.EntityFrameworkCore;

namespace ProFrom
{
    public partial class CourseSession : Form
    {
        proContext db = new proContext();


        public CourseSession()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            db.CourseSessions.Load();
            db.Courses.Load();
            db.Instructors.Load();
            View1.Refresh();

            var courseSessions = db.CourseSessions.Local.Select(cs => new
            {
                cs.CourseSessionId,
                CourseName = cs.Course != null ? cs.Course.Name : "No Course",
                InstructorName = cs.Instructor != null ? cs.Instructor.FName + " " + cs.Instructor.LNAME : "No Instructor",
                cs.Date,
                cs.Title
            }).ToList();

            View1.DataSource = courseSessions;

            comboCourse.DataSource = db.Courses.Local.ToBindingList();
            comboCourse.DisplayMember = "Name";
            comboCourse.ValueMember = "CourseId";

            comboInstructor.DataSource = db.Instructors.Local.ToBindingList();
            comboInstructor.DisplayMember = "FName";
            comboInstructor.ValueMember = "InstructorId";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            View1.EndEdit();
            db.SaveChanges();
        }

        private void comboSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSession.SelectedValue == null || comboSession.SelectedValue is not int)
                return;

            try
            {
                int sessionId = Convert.ToInt32(comboSession.SelectedValue);
                var session = db.CourseSessions.FirstOrDefault(cs => cs.CourseSessionId == sessionId);

                if (session != null)
                {
                    comboCourse.SelectedValue = session.CourseId;
                    comboInstructor.SelectedValue = session.InstId;
                    dateTimePicker1.Value = session.Date;
                    txtTitle.Text = session.Title;
                }
                else
                {
                    MessageBox.Show("Course session not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (comboSession.SelectedValue == null || comboSession.SelectedValue is not int)
                return;

            int sessionId = Convert.ToInt32(comboSession.SelectedValue);
            var session = db.CourseSessions.FirstOrDefault(cs => cs.CourseSessionId == sessionId);

            try
            {
                if (session != null)
                {
                    session.CourseId = Convert.ToInt32(comboCourse.SelectedValue);
                    session.InstId = Convert.ToInt32(comboInstructor.SelectedValue);
                    session.Date = dateTimePicker1.Value;
                    session.Title = txtTitle.Text;

                    View1.Refresh();
                    MessageBox.Show("Course Session updated successfully.");
                }
                else
                {
                    MessageBox.Show("Course session not found.");
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
                var courseSession = new CodeFirstOnly.Models.CourseSession
                {
                    CourseId = Convert.ToInt32(comboCourse.SelectedValue),
                    InstId = Convert.ToInt32(comboInstructor.SelectedValue),
                    Date = dateTimePicker1.Value,
                    Title = txtTitle.Text
                };

                db.CourseSessions.Add(courseSession);
                View1.Refresh();
                MessageBox.Show("Course Session added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboSession.SelectedValue == null || comboSession.SelectedValue is not int)
                return;

            int sessionId = Convert.ToInt32(comboSession.SelectedValue);
            var session = db.CourseSessions.FirstOrDefault(cs => cs.CourseSessionId == sessionId);

            try
            {
                if (session != null)
                {
                    db.CourseSessions.Remove(session);
                    View1.Refresh();
                    MessageBox.Show("Course Session deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Course session not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}

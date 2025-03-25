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
    public partial class CourseSessionAttendanceForm : Form
    {
        proContext db = new proContext();

        public CourseSessionAttendanceForm()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            db.CourseSessionAttendances.Load();
            db.Students.Load();
            db.CourseSessions.Load();

            View1.Refresh();

            var attendances = db.CourseSessionAttendances.Local.Select(a => new
            {
                a.Id,
                SessionTitle = a.CourseSession != null ? a.CourseSession.Title : "No Session",
                StudentName = a.student != null ? a.student.FName + " " + a.student.LName : "No Student",
                a.Grade,
                a.Notes
            }).ToList();

            View1.DataSource = attendances;

            comboSession.DataSource = db.CourseSessions.Local.ToBindingList();
            comboSession.DisplayMember = "Title";
            comboSession.ValueMember = "CourseSessionId";

            comboStudent.DataSource = db.Students.Local.ToBindingList();
            comboStudent.DisplayMember = "FirstName";
            comboStudent.ValueMember = "ID";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            View1.EndEdit();
            db.SaveChanges();
        }

        private void comboAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAttendance.SelectedValue == null || comboAttendance.SelectedValue is not int)
                return;

            try
            {
                int attendanceId = Convert.ToInt32(comboAttendance.SelectedValue);
                var attendance = db.CourseSessionAttendances.FirstOrDefault(a => a.Id == attendanceId);

                if (attendance != null)
                {
                    comboSession.SelectedValue = attendance.CSId;
                    comboStudent.SelectedValue = attendance.StId;
                    txtGrade.Text = attendance.Grade.ToString();
                    txtNotes.Text = attendance.Notes;
                }
                else
                {
                    MessageBox.Show("Attendance record not found.");
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
                var attendance = new CodeFirstOnly.Models.CourseSessionAttendance
                {
                    CSId = Convert.ToInt32(comboSession.SelectedValue),
                    StId = Convert.ToInt32(comboStudent.SelectedValue),
                    Grade = Convert.ToInt32(txtGrade.Text),
                    Notes = txtNotes.Text
                };

                db.CourseSessionAttendances.Add(attendance);
                View1.Refresh();
                MessageBox.Show("Attendance added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (comboAttendance.SelectedValue == null || comboAttendance.SelectedValue is not int)
                return;

            int attendanceId = Convert.ToInt32(comboAttendance.SelectedValue);
            var attendance = db.CourseSessionAttendances.FirstOrDefault(a => a.Id == attendanceId);

            try
            {
                if (attendance != null)
                {
                    attendance.CSId = Convert.ToInt32(comboSession.SelectedValue);
                    attendance.StId = Convert.ToInt32(comboStudent.SelectedValue);
                    attendance.Grade = Convert.ToInt32(txtGrade.Text);
                    attendance.Notes = txtNotes.Text;

                    View1.Refresh();
                    MessageBox.Show("Attendance updated successfully.");
                }
                else
                {
                    MessageBox.Show("Attendance record not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboAttendance.SelectedValue == null || comboAttendance.SelectedValue is not int)
                return;

            int attendanceId = Convert.ToInt32(comboAttendance.SelectedValue);
            var attendance = db.CourseSessionAttendances.FirstOrDefault(a => a.Id == attendanceId);

            try
            {
                if (attendance != null)
                {
                    db.CourseSessionAttendances.Remove(attendance);
                    View1.Refresh();
                    MessageBox.Show("Attendance deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Attendance record not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}

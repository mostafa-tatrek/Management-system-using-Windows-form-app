using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using CodeFirstOnly.Context;
using CodeFirstOnly.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProFrom
{

    public partial class Depatment : Form
    {
        proContext db = new proContext();

        public Depatment()
        {
            InitializeComponent();
        }
        private void Load_Click(object sender, EventArgs e)
        {
            db.Instructors.Load();
            db.Departments.Load();
            db.Courses.Load();
            View2.Refresh();
            var Department = db.Departments.Local.Select(d => new
            {
                d.DepartmentId,
                d.Name,
                d.Location,
                d.ManagerId,
                ManagerName = d.Instructors.FirstOrDefault(i => i.InstructorId == d.ManagerId) != null
              ? d.Instructors.FirstOrDefault(i => i.InstructorId == d.ManagerId).FName
              : "No Manager",

                instructorName = d.Instructors.Any() ? string.Join(",", d.Instructors.Select(i => i.FName)) : "No Instructors",
                Courses = d.Courses.Any() ? string.Join(",", d.Courses.Select(c => c.Name)) : "No Courses"
            }).ToList();
            View2.DataSource = Department;

            combomanger.DataSource = db.Instructors.Local.ToBindingList();
            combomanger.DisplayMember = "FName";
            combomanger.ValueMember = "InstructorId";
            comboBox1.DataSource = db.Departments.Local.ToBindingList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "DepartmentId";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            View2.EndEdit();
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
                if (int.TryParse(comboBox1.SelectedValue.ToString(), out int DepartmentId))
                {
                    var Department = db.Departments.FirstOrDefault(d => d.DepartmentId == DepartmentId);

                    if (Department != null)
                    {
                        name.Text = Department.Name;
                        Location.Text = Department.Location;
                        combomanger.SelectedValue = Department.ManagerId;

                    }
                    else
                    {
                        MessageBox.Show("The instructor was not found.");
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
            try
            {
                if (comboBox1.SelectedValue == null || !int.TryParse(comboBox1.SelectedValue.ToString(), out int departmentId))
                {
                    MessageBox.Show("Please select a valid department.");
                    return;
                }

                var department = db.Departments.FirstOrDefault(d => d.DepartmentId == departmentId);
                if (department != null)
                {
                    department.Name = name.Text;
                    department.Location = Location.Text;
                    department.ManagerId = (int)(combomanger.SelectedValue != null ? (int)combomanger.SelectedValue : (int?)null);

                    View2.Refresh();
                    comboBox1.DataSource = null;
                    comboBox1.DataSource = db.Departments.Local.ToBindingList();
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "DepartmentId";
                }

                else
                {
                    MessageBox.Show("Department not found.");
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
                if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(Location.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                var newDepartment = new Department
                {
                    Name = name.Text,
                    Location = Location.Text,
                    ManagerId = (int)(combomanger.SelectedValue != null ? (int)combomanger.SelectedValue : (int?)null)
                };

                db.Departments.Add(newDepartment);
                View2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
    {
                if (comboBox1.SelectedValue == null || !int.TryParse(comboBox1.SelectedValue.ToString(), out int departmentId))
                {
                    MessageBox.Show("Please select a valid department.");
                    return;
                }

                var department = db.Departments.FirstOrDefault(d => d.DepartmentId == departmentId);
                if (department != null)
                {
                    db.Departments.Remove(department);
                    View2.Refresh();

                    MessageBox.Show("Department deleted successfully.");

                }
                else
                {
                    MessageBox.Show("Department not found.");
                }
            }
        
            catch (Exception ex)
           {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
    }
}

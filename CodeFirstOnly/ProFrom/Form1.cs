using Microsoft.EntityFrameworkCore;
using CodeFirstOnly.Context;
using CodeFirstOnly.Models;
namespace ProFrom

{
    public partial class Form1 : Form
    {
        proContext db = new proContext();

        public Form1()
        {
            InitializeComponent();

        }

        private void Load_Click(object sender, EventArgs e)
        {
            db.Instructors.Load();
            db.Departments.Load();
            db.Courses.Load();
            View1.Refresh();
            var instructors = db.Instructors.Local.Select(i => new
            {
                i.InstructorId,
                FullName = i.FName + " " + i.LNAME,
                i.Phone,
                DepartmentName = i.Department != null ? i.Department.Name : "No Department",
                Courses = i.Courses.Any() ? string.Join(",", i.Courses.Select(c => c.Name)) : "No Courses"
              
            }).ToList();
            View1.DataSource = instructors;

            comboBox1.DataSource = db.Instructors.Local.ToBindingList();
            comboBox1.DisplayMember = "FName";
            comboBox1.ValueMember = "InstructorId";
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
                if (int.TryParse(comboBox1.SelectedValue.ToString(), out int instructorId))
                {
                    var instructor = db.Instructors.FirstOrDefault(s => s.InstructorId == instructorId);

                    if (instructor != null)
                    {
                        FName.Text = instructor.FName;
                        LName.Text = instructor.LNAME;
                        Phone.Text = instructor.Phone;
                        //Departid.Text = instructor.DeptId.ToString();
                        comboDept.SelectedValue = instructor.DeptId; 

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
            int InstructorId = Convert.ToInt32(comboBox1.SelectedValue);

            var Instructor = db.Instructors.FirstOrDefault(s => s.InstructorId == InstructorId);

            try
            {
                if (Instructor != null)
                {
                    Instructor.FName = FName.Text;
                    Instructor.LNAME = LName.Text;
                    Instructor.Phone = Phone.Text;
                    Instructor.DeptId = Convert.ToInt32(comboDept.SelectedValue);


                    View1.Refresh();
                    comboBox1.DataSource = null;
                    comboBox1.DataSource = db.Instructors.Local.ToBindingList();
                    comboBox1.DisplayMember = "FName";
                    comboBox1.ValueMember = "InstructorId";

                }
                else
                {
                    MessageBox.Show("The instructor was not found.");
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
                var instructor = new Instructor
                {
                    FName = FName.Text,
                    LNAME = LName.Text,
                    Phone = Phone.Text,
                    DeptId = Convert.ToInt32(comboDept.SelectedValue)
                };

                db.Instructors.Add(instructor);
                View1.Refresh();
                MessageBox.Show("Instructor added successfully.");
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
                if (comboBox1.SelectedValue == null || comboBox1.SelectedValue is not int)
                {
                    return;
                }

                int instructorId = Convert.ToInt32(comboBox1.SelectedValue);
                var instructor = db.Instructors.FirstOrDefault(s => s.InstructorId == instructorId);

                if (instructor != null)
                {
                    db.Instructors.Remove(instructor);
                    View1.Refresh();
                    MessageBox.Show("Instructor deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Instructor not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }

}
    


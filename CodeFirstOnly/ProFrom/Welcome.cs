using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFrom
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Instructor_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Depatment().Show();
        }

        private void Courses_Click(object sender, EventArgs e)
        {
            new Course().Show();
        }

        private void CoursesSession_Click(object sender, EventArgs e)
        {
            new CourseSession().Show();
        }

        private void CoursesSessionAtt_Click(object sender, EventArgs e)
        {
            new CourseSessionAttendanceForm().Show();
        }

        private void Students_Click(object sender, EventArgs e)
        {
            new StudentForm().Show();
        }
    }
}
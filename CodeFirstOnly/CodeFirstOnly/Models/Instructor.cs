using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOnly.Models
{
    public class Instructor
    {
       
        public int InstructorId { get; set; }
        [StringLength(255)]
        public string? FName { get; set; }
        [StringLength(255)]
        public string? LNAME { get; set; }
        [StringLength(255)]
        public string? Phone { get; set; }
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public Department Department { get; set; }
        public virtual ICollection<Course> Courses { get;   set; }=new List<Course>();
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new HashSet<CourseSession>();

    }
}

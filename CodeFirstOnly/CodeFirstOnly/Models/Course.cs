using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOnly.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public int? Duration { get; set; }
        [StringLength(255)]
        public string? Name { get; set; }
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public Department Department { get; set; }
        [ForeignKey("Instructor")]
        public int InstId { get; set; }
        public Instructor Instructor { get; set; }
         public virtual ICollection<CourseSession> CourseSessions { get; set; }= new HashSet<CourseSession>();
        public virtual ICollection<Student> Students { get; set; }=new HashSet<Student>();
            
    }
}

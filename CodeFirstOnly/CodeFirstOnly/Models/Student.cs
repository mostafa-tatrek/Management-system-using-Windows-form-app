using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOnly.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [StringLength(255)]
        public string? FName { get; set; }
        [StringLength(255)]
        public string? LName { get; set; }
        [StringLength(255)]
        public string? Phone { get; set; }
       public virtual ICollection<CourseSessionAttendance> CourseSessionAttendances { get; set; }=new HashSet<CourseSessionAttendance>(); 
        public virtual ICollection<Course> Courses { get; set; } =new HashSet<Course>();
    }
} 

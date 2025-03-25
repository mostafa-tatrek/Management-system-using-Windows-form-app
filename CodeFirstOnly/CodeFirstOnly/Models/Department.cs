using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOnly.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string? Location { get; set; }
        public int ManagerId { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
       = new HashSet<Instructor>();
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}

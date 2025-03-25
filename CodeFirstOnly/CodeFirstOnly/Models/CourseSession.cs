using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOnly.Models
{
    public class CourseSession
    {
        public int CourseSessionId { get; set; }
        [StringLength(255)]
        public string? Title { get; set;}    
        public DateTime Date { get; set;}
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get;set;}
        [ForeignKey("Instructor")]
        public int? InstId { get; set; }
        public Instructor Instructor { get; set; }  
        public virtual ICollection<CourseSessionAttendance> CourseSessionAttendances { get;set; }= new List<CourseSessionAttendance>();
    }
}

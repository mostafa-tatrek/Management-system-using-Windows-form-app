using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOnly.Models
{
    public class CourseSessionAttendance
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string? Notes { get; set; }
        public int? Grade { get; set; }
        [ForeignKey("Course")]
        public int CSId { get; set; }
        public CourseSession CourseSession { get; set; }
        [ForeignKey("Student")]
        public int StId { get; set; }
        public Student student { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CodeFirstOnly.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstOnly.Context
{
    public class proContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-UHUN6R1\\SQLEXPRESS;Database=Pro;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
        public virtual DbSet<Student> Students { set; get; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseSession> CourseSessions { get; set; }
        public  virtual DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }

    }
}

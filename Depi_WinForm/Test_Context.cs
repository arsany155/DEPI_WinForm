using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depi_WinForm
{
    public class Test_Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Instructor_Course> Instructor_Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-KIIGCN4\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure composite primary key for Student_Course
            modelBuilder.Entity<Student_Course>()
                .HasKey(sc => new { sc.StId, sc.CrsId });

            // Configure the relationship between Student and Student_Course
            modelBuilder.Entity<Student_Course>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.Student_Courses)
                .HasForeignKey(sc => sc.StId);

            // Configure the relationship between Course and Student_Course
            modelBuilder.Entity<Student_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.Student_Courses)
                .HasForeignKey(sc => sc.CrsId);


            //--------------------------------------------------------------------

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.Departments)
                .WithOne(d => d.instructors);

            //modelBuilder.Entity<Department>()
            //    .HasMany(d => d.Instructors)
            //    .WithOne(e => e.department);

            //---------------------------------------------------------------------

            modelBuilder.Entity<Instructor_Course>()
                .HasKey(ic => new { ic.CrsId, ic.InsId });

            modelBuilder.Entity<Instructor_Course>()
                .HasOne(ic => ic.Instructor)
                .WithMany(i => i.Instructor_Courses)
                .HasForeignKey(ic => ic.InsId);

            modelBuilder.Entity<Instructor_Course>()
                .HasOne(ic => ic.Course)
                .WithMany(c => c.Instructor_Courses)
                .HasForeignKey(ic => ic.CrsId);
        }
    }
}

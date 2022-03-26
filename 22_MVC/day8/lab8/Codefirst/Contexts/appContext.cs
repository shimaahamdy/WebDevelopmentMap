using Codefirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Codefirst.Contexts
{
    public class appContext:DbContext
    {
        public appContext(DbContextOptions<appContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBilder)
        {
            modelBilder.Entity<StudentCourse>()
                .HasOne(c => c.Course)
                .WithMany(SC => SC.StudentCourse)
                .HasForeignKey(CI => CI.CourseID);


            modelBilder.Entity<StudentCourse>()
                .HasOne(s => s.Student)
                .WithMany(SC => SC.StudentCourse)
                .HasForeignKey(SI => SI.StudentId);

            

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }

    }
}

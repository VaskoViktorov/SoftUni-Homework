using Microsoft.EntityFrameworkCore;

namespace _04._Many_to_Many
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=.;Database=TestDb;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentCourses>()
                .HasKey(sc => new {sc.StudentId, sc.CourseId});

            builder.Entity<StudentCourses>()
                .HasOne<Student>(s => s.Student)
                .WithMany(sc => sc.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            builder.Entity<StudentCourses>()
                .HasOne(c => c.Course)
                .WithMany(sc => sc.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);
        }

       
    }

}

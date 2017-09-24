using Microsoft.EntityFrameworkCore;

namespace _02._One_to_Many
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=.;Database=TestDb;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>()
                .HasOne(emp => emp.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(emp => emp.DepartmentId);
        }
    }
}

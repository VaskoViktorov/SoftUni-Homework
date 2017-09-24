using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace _03._Self_Ref
{

    public class AppDbContext :DbContext
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

            builder.Entity<Employee>()
                .HasOne(m => m.Manager)
                .WithMany(e => e.Employees)
                .HasForeignKey(m => m.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

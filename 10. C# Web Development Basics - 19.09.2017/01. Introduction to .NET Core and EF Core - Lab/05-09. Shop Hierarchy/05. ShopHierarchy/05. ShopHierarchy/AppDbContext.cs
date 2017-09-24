using Microsoft.EntityFrameworkCore;

namespace _05._ShopHierarchy
{
    public class AppDbContext : DbContext
    {
        public DbSet<Salesmen> Salesmen { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=.;Database=TestDb;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>()
                 .HasOne(s => s.Salesmen)
                 .WithMany(c => c.Customers)
                 .HasForeignKey(s => s.SalesmenId);

            builder.Entity<Order>()
                .HasOne(c => c.Customer)
                .WithMany(o => o.Orders)
                .HasForeignKey(c => c.CustomerId);

            builder.Entity<Review>()
                .HasOne(c => c.Customer)
                .WithMany(o => o.Reviews)
                .HasForeignKey(c => c.CustomerId);

            builder.Entity<Item>()
                .HasMany(r => r.Reviews)
                .WithOne(i => i.Item)
                .HasForeignKey(r => r.ItemId);

            builder.Entity<ItemOrder>()
                .HasKey(io => new {io.ItemId, io.OrderId});

            builder.Entity<Item>()
                .HasMany(i => i.Orders)
                .WithOne(io => io.Item)
                .HasForeignKey(io => io.ItemId);       

            builder.Entity<Order>()
                .HasMany(o => o.Items)
                .WithOne(io => io.Order)
                .HasForeignKey(io => io.OrderId);
        }


    }

}
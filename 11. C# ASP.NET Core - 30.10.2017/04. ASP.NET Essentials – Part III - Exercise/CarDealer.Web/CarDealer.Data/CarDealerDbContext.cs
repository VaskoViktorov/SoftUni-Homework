﻿namespace CarDealer.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class CarDealerDbContext : IdentityDbContext<User>
    {       
        public CarDealerDbContext(DbContextOptions<CarDealerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Sale> Sales { get; set; }
    
        public DbSet<Part> Parts { get; set; }

        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Sale>()
                .HasOne(s => s.Car)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.CarId);

            builder
                .Entity<Sale>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.CustomerId);

            builder
                .Entity<Supplier>()
                .HasMany(s => s.Parts)
                .WithOne(p => p.Supplier)
                .HasForeignKey(p => p.SupplierId);

            builder
                .Entity<PartCar>()
                .HasKey(k => new {k.PartId, k.CarId});

            builder
                .Entity<PartCar>()
                .HasOne(pc => pc.Part)
                .WithMany(p => p.Cars)
                .HasForeignKey(pc => pc.PartId);

            builder
                .Entity<PartCar>()
                .HasOne(pc => pc.Car)
                .WithMany(p => p.Parts)
                .HasForeignKey(pc => pc.CarId);

            base.OnModelCreating(builder);
        }
    }
}

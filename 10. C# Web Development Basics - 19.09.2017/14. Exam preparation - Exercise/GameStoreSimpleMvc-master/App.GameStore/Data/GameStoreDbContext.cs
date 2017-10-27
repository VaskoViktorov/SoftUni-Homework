using System;
using System.Collections.Generic;
using System.Text;
using App.GameStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace App.GameStore.Data
{
    public class GameStoreDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=.;Database=GameStoreAppDb;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            builder
                .Entity<Order>()
                .HasKey(k => new {k.UserId, k.GameId});

            builder
                .Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Games)
                .HasForeignKey(o => o.UserId);

            builder
                .Entity<Order>()
                .HasOne(o => o.Game)
                .WithMany(g => g.Users)
                .HasForeignKey(o => o.GameId);
        }
    }
}

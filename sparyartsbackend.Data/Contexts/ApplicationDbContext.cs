using Microsoft.EntityFrameworkCore;
using sprayartsbackend.Domain.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace sprayartsbackend.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions  options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
        }

        public DbSet<User> Users { get; set; }

    }
}

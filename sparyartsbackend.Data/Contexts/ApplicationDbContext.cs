using Microsoft.EntityFrameworkCore;
using sprayartsbackend.Domain.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            ////Fazendo o mapeamento com o banco de dados
            ////Pega todas as classes que estão implementando a interface IMapping
            ////Assim o Entity Framework é capaz de carregar os mapeamentos
            //var typesToMapping = (from x in Assembly.GetExecutingAssembly().GetTypes()
            //                      where x.IsClass && typeof(EntityTypeConfiguration<T>).IsAssignableFrom(x)
            //                      select x).ToList();

            //// Varrendo todos os tipos que são mapeamento 
            //// Com ajuda do Reflection criamos as instancias 
            //// e adicionamos no Entity Framework
            //foreach (var mapping in typesToMapping)
            //{
            //    dynamic mappingClass = Activator.CreateInstance(mapping);
            //    modelBuilder.ApplyConfiguration(mappingClass);
            //}

            modelBuilder.Entity<User>().ToTable("User");
        }

        public DbSet<User> Users { get; set; }

    }
}

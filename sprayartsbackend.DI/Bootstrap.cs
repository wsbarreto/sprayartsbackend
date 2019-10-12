using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using sparyartsbackend.Data;
using sprayartsbackend.Data.Contexts;
using sprayartsbackend.Data.Repositories;
using sprayartsbackend.Domain;
using sprayartsbackend.Domain.Account;
using System;

namespace sprayartsbackend.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));


            //Aqui ficará centralizado todas as injeções de dependência do sistema
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(UserStorer));
            services.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));

        }
    }
}

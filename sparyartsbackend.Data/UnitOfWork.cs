using sprayartsbackend.Data.Contexts;
using sprayartsbackend.Domain;
using System;
using System.Threading.Tasks;

namespace sparyartsbackend.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}

using sprayartsbackend.Data.Contexts;
using sprayartsbackend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sprayartsbackend.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> All()
        {
            var query = _context.Set<TEntity>();

            if (query.Any())
                return query.ToList();

            return new List<TEntity>();
        }

        public TEntity GetById(int id)
        {
            var query = _context.Set<TEntity>().Where(e => e.Id == id);
            if (query.Any())
                return query.FirstOrDefault();
            return null;
        }

        public void Save(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }
    }
}

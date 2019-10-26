using System;
using System.Collections.Generic;
using System.Text;

namespace sprayartsbackend.Domain
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> All();
        IEnumerable<TEntity> GetPredicate(Func<TEntity, bool> predicate);
        TEntity GetById(Guid id);
        void Save(TEntity entity);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace sprayartsbackend.Domain
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> All();
        TEntity GetById(int id);
        void Save(TEntity entity);
    }
}

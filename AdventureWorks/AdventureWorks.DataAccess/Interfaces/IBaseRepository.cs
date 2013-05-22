using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Model;

namespace AdventureWorks.DataAccess
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        TEntity Create();
        void Add(TEntity entity);
        void Delete(TEntity entity);
        IQueryable<TEntity> GetAll();
        TEntity GetByKey(params object[] keyValues);
        void SaveChanges();
    }
}

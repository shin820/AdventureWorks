using System;
using System.Linq;
using System.Linq.Expressions;
using AdventureWorks.Model;

namespace AdventureWorks.DataAccess.Repositories.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> filter);
        IQueryable<TEntity> FindAll();
        void SaveChanges<T>(T root) where T : ObjectWithState;
        void SaveChanges();
        void RollbackChanges();
    }
}

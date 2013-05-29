using System;
using System.Linq;
using System.Linq.Expressions;
using AdventureWorks.Model;

namespace AdventureWorks.DataAccess.Repositories.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> FindAll();
        //IQueryable<TEntity> FindAll(int pageIndex,int pageSize,ref in count);

        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> filter);

        //IQueryable<TEntity> FindBy<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> orderby,int pageIndex, int pageSize, ref int count);

        //TEntity Find(TEntityKey id);

        //void SaveChanges(TEntity root);
        //void SaveChanges();

        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}

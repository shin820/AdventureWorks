using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDbContext Context { get; set; }

        public UnitOfWork(IDbContext context)
        {
            Context = context;
        }

        public void RegisterNew<TEntity>(TEntity entity) where TEntity : class
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void RegisterUnchanged<TEntity>(TEntity entity) where TEntity : class
        {
            Context.Entry(entity).State = EntityState.Unchanged;
        }

        public void RegisterChanged<TEntity>(TEntity entity) where TEntity : class
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public void RegisterDeleted<TEntity>(TEntity entity) where TEntity : class
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void Refresh()
        {
            Context.Rollback();
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}

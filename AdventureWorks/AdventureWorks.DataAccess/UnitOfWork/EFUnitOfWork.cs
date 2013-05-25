using System;
using System.Data.Entity;

namespace AdventureWorks.DataAccess.UnitOfWork
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public IDbContext Context { get; set; }

        public EFUnitOfWork(IDbContext context)
        {
            Context = context;
        }

        public void RegisterNew<TEntity>(TEntity entity, IUnitOfWorkRepository<TEntity> unitOfWorkRepository)
            where TEntity : class
        {
            unitOfWorkRepository.PersistCreation(entity);
        }

        public void RegisterChanged<TEntity>(TEntity entity, IUnitOfWorkRepository<TEntity> unitOfWorkRepository)
            where TEntity : class
        {
            unitOfWorkRepository.PersistUpdate(entity);
        }

        public void RegisterDeleted<TEntity>(TEntity entity, IUnitOfWorkRepository<TEntity> unitOfWorkRepository)
            where TEntity : class
        {
            unitOfWorkRepository.PersistDeletion(entity);
        }

        public void Commit()
        {
            try
            {
                Context.SaveChanges();
            }
            catch (Exception)
            {
                Context.Rollback();
                throw;
            }
        }
    }
}

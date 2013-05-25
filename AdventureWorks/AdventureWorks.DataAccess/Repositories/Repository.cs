using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.DataAccess.UnitOfWork;
using AdventureWorks.Model;

namespace AdventureWorks.DataAccess.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity>,IUnitOfWorkRepository<TEntity>
        where TEntity : ObjectWithState
    {
        private readonly IUnitOfWork _unitOfWork;

        protected readonly IDbContext DbContext;

        protected Repository(IDbContext dbContext, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            DbContext = dbContext;
        }

        public void Add(TEntity entity)
        {
            _unitOfWork.RegisterNew(entity, this);
        }

        public virtual void Delete(TEntity entity)
        {
            _unitOfWork.RegisterDeleted(entity, this);
        }

        public void Update(TEntity entity)
        {
            _unitOfWork.RegisterChanged(entity, this);
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> filter)
        {
            return DbContext.Set<TEntity>().Where(filter);
        }

        public IQueryable<TEntity> FindAll()
        {
            return DbContext.FindAll<TEntity>();
        }

        #region IUnitOfWorkRepository implementation

        public void PersistCreation(TEntity entity)
        {
            DbContext.Set<TEntity>().Add(entity);
        }

        public void PersistUpdate(TEntity entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
        }

        public void PersistDeletion(TEntity entity)
        {
            DbContext.Set<TEntity>().Remove(entity);
        }

        #endregion

    }
}

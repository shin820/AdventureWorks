using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.Model;

namespace AdventureWorks.DataAccess.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly IUnitOfWork _unitOfWork;

        protected IDbContext DbContext
        {
            get { return _unitOfWork.Context; }
        }

        protected Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(TEntity entity)
        {
            _unitOfWork.RegisterNew(entity);
        }

        public void Delete(TEntity entity)
        {
            _unitOfWork.RegisterDeleted(entity);
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> filter)
        {
            return DbContext.Set<TEntity>().Where(filter);
        }

        public IQueryable<TEntity> FindAll()
        {
            return DbContext.FindAll<TEntity>();
        }

        public void SaveChanges()
        {
            try
            {
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Refresh();
                throw;
            }
        }

        public void RollbackChanges()
        {
            _unitOfWork.Refresh();
        }

        #region Save for disconnected enetity

        public void SaveChanges<T>(T root) where T : ObjectWithState
        {
            _unitOfWork.RegisterNew(root);

            CheckForEntitiesWithoutStateInterface();

            foreach (var entry in DbContext.ChangeTracker.Entries<ObjectWithState>())
            {
                ObjectWithState stateInfo = entry.Entity;
                entry.State = ConvertState(stateInfo.State);

                if (stateInfo.State == State.UnChanged)
                {
                    ApplyPropertyChnages(entry.OriginalValues, stateInfo.OriginalValues);
                }
            }

            _unitOfWork.Commit();
        }

        private void CheckForEntitiesWithoutStateInterface()
        {
            var entitiesWithoutStateInterface = from e in DbContext.ChangeTracker.Entries()
                                                where !(e.Entity is ObjectWithState)
                                                select e;

            if (entitiesWithoutStateInterface.Any())
            {
                throw new NotSupportedException("All entities must implemented ObjectWithState");
            }
        }

        private void ApplyPropertyChnages(DbPropertyValues values, IDictionary<string, object> originalValues)
        {
            foreach (var originalValue in originalValues)
            {
                var complexTypeProperty = originalValue.Value as IDictionary<string, object>;
                if (complexTypeProperty != null)
                {
                    ApplyPropertyChnages((DbPropertyValues)values[originalValue.Key], complexTypeProperty);
                }
                else
                {
                    values[originalValue.Key] = originalValue.Value;
                }
            }
        }

        private EntityState ConvertState(State state)
        {
            switch (state)
            {
                case State.Added:
                    return EntityState.Added;
                case State.Deleted:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }
        }

        #endregion
    }
}

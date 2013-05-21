using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AdventureWorks.Model;
using System.Linq.Expressions;

namespace AdventureWorks.DataAccess
{
    public class Repository : IRepository
    {
        private readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Find<T>(Expression<Func<T, bool>> filter) where T : class
        {
            return _dbContext.Set<T>().Where(filter);
        }

        public T Update<T>(T entity) where T : class
        {
            _dbContext.SaveChanges();
            return entity;
        }

        public T Add<T>(T entity) where T : class
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete<T>(T entity) where T : class
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void SaveChanges<T>(T root) where T : ObjectWithState
        {
            _dbContext.Set<T>().Add(root);

            CheckForEntitiesWithoutStateInterface();

            foreach (var entry in _dbContext.ChangeTracker.Entries<ObjectWithState>())
            {
                ObjectWithState stateInfo = entry.Entity;
                entry.State = ConvertState(stateInfo.State);

                if (stateInfo.State == State.UnChanged)
                {
                    ApplyPropertyChnages(entry.OriginalValues, stateInfo.OriginalValues);
                }
            }

            _dbContext.SaveChanges();
        }

        private void CheckForEntitiesWithoutStateInterface()
        {
            var entitiesWithoutStateInterface = from e in _dbContext.ChangeTracker.Entries()
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
                    ApplyPropertyChnages((DbPropertyValues) values[originalValue.Key], complexTypeProperty);
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
    }
}

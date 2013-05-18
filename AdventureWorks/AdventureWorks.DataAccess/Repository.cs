using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AdventureWorks.Model;

namespace AdventureWorks.DataAccess
{
    public class Repository : IRepository
    {
        protected DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> FindAll<T>() where T : class
        {
            return _dbContext.Set<T>().AsQueryable();
        }

        public T Find<T>(int id) where T : class
        {
            return _dbContext.Set<T>().Find(id);
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
                IDictionary<string, object> complexTypeProperty = originalValue.Value as IDictionary<string, object>;
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

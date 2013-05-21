using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Model;
using System.Data.Entity.Infrastructure;

namespace AdventureWorks.DataAccess
{
    public interface IRepository
    {
        IQueryable<T> Find<T>(Expression<Func<T, bool>> filter) where T : class;
        T Update<T>(T entity) where T : class;
        T Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void SaveChanges<T>(T root) where T : ObjectWithState;
    }
}

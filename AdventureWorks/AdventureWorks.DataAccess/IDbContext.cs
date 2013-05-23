using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using AdventureWorks.Model;

namespace AdventureWorks.DataAccess
{
    public interface IDbContext
    {
        DbChangeTracker ChangeTracker { get; }
        DbSet<T> Set<T>() where T : class;
        IQueryable<T> FindAll<T>() where T : class;
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
        void Rollback();
    }
}

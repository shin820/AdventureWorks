using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DataAccess.UnitOfWork
{
    public interface IUnitOfWorkRepository<TEntity> where TEntity : class
    {
        void PersistCreation(TEntity entity);
        void PersistUpdate(TEntity entity);
        void PersistDeletion(TEntity entity);
    }
}

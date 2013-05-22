using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DataAccess
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly DbContext _context;

        protected DbContext Context
        {
            get { return _context; }
        }

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public TEntity Create()
        {
            return _context.Set<TEntity>().Create<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsQueryable();
        }

        public TEntity GetByKey(params object[] keyValues)
        {
            return _context.Set<TEntity>().Find(keyValues);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

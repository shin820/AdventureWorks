namespace AdventureWorks.DataAccess
{
    public interface IUnitOfWork
    {
        void RegisterNew<TEntity>(TEntity entity) where TEntity : class;
        void RegisterUnchanged<TEntity>(TEntity entity) where TEntity : class;
        void RegisterChanged<TEntity>(TEntity entity) where TEntity : class;
        void RegisterDeleted<TEntity>(TEntity entity) where TEntity : class;
        void Refresh();
        void Commit();
        IDbContext Context { get; set; }
    }
}

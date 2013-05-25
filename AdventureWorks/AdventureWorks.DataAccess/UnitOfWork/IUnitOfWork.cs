namespace AdventureWorks.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        void RegisterNew<TEntity>(TEntity entity, IUnitOfWorkRepository<TEntity> unitOfWorkRepository) where TEntity : class;
        void RegisterChanged<TEntity>(TEntity entity, IUnitOfWorkRepository<TEntity> unitOfWorkRepository) where TEntity : class;
        void RegisterDeleted<TEntity>(TEntity entity, IUnitOfWorkRepository<TEntity> unitOfWorkRepository) where TEntity : class;
        void Commit();
    }
}

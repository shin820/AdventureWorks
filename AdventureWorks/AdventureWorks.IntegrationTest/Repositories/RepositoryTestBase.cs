using System;
using System.Linq;
using System.Linq.Expressions;
using AdventureWorks.DataAccess;
using AdventureWorks.DataAccess.UnitOfWork;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.Model.HumanResources;
using NUnit.Framework;

namespace AdventureWorks.IntegrationTest.Repositories
{
    public abstract class RepositoryTestBase<TEntity> where TEntity : class
    {
        protected AdventureWorksContext Context;
        protected IUnitOfWork UnitOfWork;

        [TestFixtureSetUp]
        public void BaseTestFixtureSetUp()
        {
            Context = new AdventureWorksContext("AdventureWorks");
            UnitOfWork = new EFUnitOfWork(Context);
        }

        [TestFixtureTearDown]
        public void BaseTestFixtureTearDown()
        {
            DeleteTestEntities();
            Context.Dispose();
        }

        [Test]
        public void ShouldAddEntity()
        {
            AddTestEntities();
            TEntity added = GetTestEntity();

            AssertEntitiesAreEqual(MakeTestEntity(), added);
        }

        [Test]
        public void ShouldUpdateEntity()
        {
            AddTestEntities();

            TEntity beforeUpdate = GetTestEntity();
            ChangePeroperties(beforeUpdate);
            UnitOfWork.Commit();

            TEntity afterUpdate = GetTestEntity();

            TEntity expected = MakeTestEntity();
            ChangePeroperties(expected);

            AssertEntitiesAreEqual(expected, afterUpdate);
        }

        [Test]
        public void ShouldDeleteEntity()
        {
            AddTestEntities();

            TEntity beforeDelete = GetTestEntity();
            GetRepository().Delete(beforeDelete);
            UnitOfWork.Commit();

            TEntity afterDelete = GetTestEntity();
            Assert.IsNull(afterDelete);
        }

        protected abstract IRepository<TEntity> GetRepository();
        protected abstract Expression<Func<TEntity, bool>> IdentifyTestEntityExpression();
        protected abstract TEntity MakeTestEntity();
        protected abstract void AssertEntitiesAreEqual(TEntity expected, TEntity actual);
        protected abstract void ChangePeroperties(TEntity entity);

        protected TEntity GetTestEntity()
        {
            return GetRepository().FindAll().Where(IdentifyTestEntityExpression()).FirstOrDefault();
        }

        protected void AddTestEntities()
        {
            DeleteTestEntities();

            GetRepository().Add(MakeTestEntity());
            UnitOfWork.Commit();
        }

        private void DeleteTestEntities()
        {
            var testDepartments = from d in GetRepository().FindAll().Where(IdentifyTestEntityExpression()) select d;
            Enumerable.ToList<TEntity>(testDepartments).ForEach(d => GetRepository().Delete(d));

            UnitOfWork.Commit();
        }
    }
}
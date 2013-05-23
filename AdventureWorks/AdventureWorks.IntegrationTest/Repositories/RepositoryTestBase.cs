using System;
using System.Linq;
using System.Linq.Expressions;
using AdventureWorks.DataAccess;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.Model.HumanResources;
using NUnit.Framework;

namespace AdventureWorks.IntegrationTest.Repositories
{
    public abstract class RepositoryTestBase<TEntity> where TEntity : class
    {
        protected AdventureWorksContext Context;
        
        [TestFixtureSetUp]
        public void BaseTestFixtureSetUp()
        {
            Context = new AdventureWorksContext("AdventureWorks");
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
            AddTestDepartments();
            TEntity added = GetTestEntity();

            AssertEntitiesAreEqual(MakeTestEntity(), added);
        }

        [Test]
        public void ShouldUpdateEntity()
        {
            AddTestDepartments();

            TEntity beforeUpdate = GetTestEntity();
            ChangePeroperties(beforeUpdate);
            GetRepository().SaveChanges();

            TEntity afterUpdate = GetTestEntity();

            TEntity expected = MakeTestEntity();
            ChangePeroperties(expected);

            AssertEntitiesAreEqual(expected, afterUpdate);
        }

        [Test]
        public void ShouldDeleteEntity()
        {
            AddTestDepartments();

            TEntity beforeDelete = GetTestEntity();
            GetRepository().Delete(beforeDelete);
            GetRepository().SaveChanges();

            TEntity afterDelete = GetTestEntity();
            Assert.IsNull(afterDelete);
        }

        protected abstract IRepository<TEntity> GetRepository();
        protected abstract Expression<Func<TEntity, bool>> IdentifyTestEntityExpression();
        protected abstract TEntity MakeTestEntity();
        protected abstract void AssertEntitiesAreEqual(TEntity expected, TEntity actual);
        protected abstract void ChangePeroperties(TEntity entity);

        private TEntity GetTestEntity()
        {
            return GetRepository().FindAll().Where(IdentifyTestEntityExpression()).FirstOrDefault();
        }

        private void AddTestDepartments()
        {
            DeleteTestEntities();

            GetRepository().Add(MakeTestEntity());
            GetRepository().SaveChanges();
        }

        private void DeleteTestEntities()
        {
            var testDepartments = from d in GetRepository().FindAll().Where(IdentifyTestEntityExpression()) select d;
            Enumerable.ToList<TEntity>(testDepartments).ForEach(d => GetRepository().Delete(d));

            GetRepository().SaveChanges();
        }
    }
}
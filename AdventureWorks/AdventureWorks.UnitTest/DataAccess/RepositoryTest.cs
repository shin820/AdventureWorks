using System.Collections.Generic;
using System.Linq;
using AdventureWorks.DataAccess;
using AdventureWorks.DataAccess.Repositories.Enum;
using AdventureWorks.DataAccess.UnitOfWork;
using AdventureWorks.UnitTest.TestHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AdventureWorks.UnitTest.DataAccess
{
    [TestClass]
    public class RepositoryTest
    {
        private IUnitOfWork _unitOfWork;
        private Mock<IDbContext> _mockDbContext;
        private FakeRepository _repository;
        private GenericFakeDbSet<FakeObject, int> _fakeDbSet;

        [TestInitialize]
        public void Initialize()
        {
            _mockDbContext = new Mock<IDbContext>();
            _fakeDbSet = FakeDbSetBuilder.New<FakeObject>().Build(t => t.Id);
            _mockDbContext.Setup(t => t.FindAll<FakeObject>()).Returns(_fakeDbSet);

            _unitOfWork = new EFUnitOfWork(_mockDbContext.Object);

            _repository = new FakeRepository(_mockDbContext.Object, _unitOfWork);
        }

        [TestMethod]
        public void ShouldAddToDbSet()
        {
            var entity = new FakeObject {Id = 1, Name = "TestName"};
            _repository.Add(entity);
            _unitOfWork.Commit();

            var result = _fakeDbSet.Find(1);
            Assert.AreEqual("TestName", result.Name);
        }

        [TestMethod]
        public void ShouldDeleteFromDbSet()
        {
            var entity = new FakeObject {Id = 1, Name = "TestName"};
            _repository.Add(entity);
            _unitOfWork.Commit();
            Assert.AreEqual(1, _fakeDbSet.Count());

            _repository.Delete(entity);
            _unitOfWork.Commit();
            Assert.AreEqual(0, _fakeDbSet.Count());
        }

        [TestMethod]
        public void ShouldGetEntitiesFromDbSet()
        {
            MakeFakeObjects().ForEach(t => _fakeDbSet.Add(t));
            var result = _repository.FindAll();
            Assert.AreEqual(5, result.Count());
        }

        [TestMethod]
        public void ShouldGetEntitiesByExpression()
        {
            MakeFakeObjects().ForEach(t => _fakeDbSet.Add(t));

            var result = _repository.FindBy(t => t.Id == 1 || t.Id == 2);

            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void ShouldPaginateData()
        {
            MakeFakeObjects().ForEach(t => _fakeDbSet.Add(t));

            int count = 0;
            var result = _repository.FindBy(t => true, t => t.Id, 2, 2, ref count).ToList();

            Assert.AreEqual(5, count);
            Assert.AreEqual("Test Name 3", result[0].Name);
            Assert.AreEqual("Test Name 4", result[1].Name);
        }

        [TestMethod]
        public void ShouldPaginateDataOrderByDesc()
        {
            MakeFakeObjects().ForEach(t => _fakeDbSet.Add(t));

            int count = 0;
            var result = _repository.FindBy(t => true, t => t.Id, OrderByType.DESC, 2, 2, ref count).ToList();

            Assert.AreEqual(5, count);
            Assert.AreEqual("Test Name 3", result[0].Name);
            Assert.AreEqual("Test Name 2", result[1].Name);
        }

        [TestMethod]
        public void ShouldFilterAndPaginateData()
        {
            MakeFakeObjects().ForEach(t => _fakeDbSet.Add(t));

            int count = 0;
            var result =
                _repository.FindBy(t => new[] {1, 3, 5}.Contains(t.Id), t => t.Id, 2, 2, ref count).ToList();

            Assert.AreEqual(3, count);
            Assert.AreEqual("Test Name 5", result[0].Name);
        }

        private List<FakeObject> MakeFakeObjects()
        {
            return new List<FakeObject>
                {
                    new FakeObject {Id = 1, Name = "Test Name 1"},
                    new FakeObject {Id = 2, Name = "Test Name 2"},
                    new FakeObject {Id = 3, Name = "Test Name 3"},
                    new FakeObject {Id = 4, Name = "Test Name 4"},
                    new FakeObject {Id = 5, Name = "Test Name 5"}
                };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.DataAccess;
using AdventureWorks.DataAccess.Repositories.Enum;
using AdventureWorks.DataAccess.UnitOfWork;
using AdventureWorks.UnitTest.TestHelper;
using NUnit.Framework;
using Moq;

namespace AdventureWorks.UnitTest
{
    public class RepositoryTest
    {
        private IUnitOfWork _unitOfWork;
        private Mock<IDbContext> _mockDbContext;
        private FakeRepository _repository;
        private GenericFakeDbSet<FakeObject, int> _fakeDbSet;

        [SetUp]
        public void SetUp()
        {
            _mockDbContext = new Mock<IDbContext>();
            _fakeDbSet = FakeDbSetBuilder.New<FakeObject>().Build(t => t.Id);
            _mockDbContext.Setup(t => t.FindAll<FakeObject>()).Returns(_fakeDbSet);

            _unitOfWork = new EFUnitOfWork(_mockDbContext.Object);

            _repository = new FakeRepository(_mockDbContext.Object, _unitOfWork);
        }

        [Test]
        public void ShouldAdd()
        {
            var entity = new FakeObject {Id = 1, Name = "TestName"};
            _repository.Add(entity);
            _unitOfWork.Commit();

            var result = _fakeDbSet.Find(1);
            Assert.AreEqual("TestName", result.Name);
        }

        [Test]
        public void ShouldDelete()
        {
            var entity = new FakeObject {Id = 1, Name = "TestName"};
            _repository.Add(entity);
            _unitOfWork.Commit();
            Assert.AreEqual(1, _fakeDbSet.Count());

            _repository.Delete(entity);
            _unitOfWork.Commit();
            Assert.AreEqual(0, _fakeDbSet.Count());
        }

        [Test]
        public void ShouldFindAllEntity()
        {
            MakeFakeObjects().ForEach(t => _fakeDbSet.Add(t));
            var result = _repository.FindAll();
            Assert.AreEqual(5, result.Count());
        }

        [Test]
        public void ShouldFindEntityByExpression()
        {
            MakeFakeObjects().ForEach(t => _fakeDbSet.Add(t));

            var result = _repository.FindBy(t => t.Id == 1 || t.Id == 2);

            Assert.AreEqual(2, result.Count());
        }

        [Test]
        public void ShouldFindByPagination()
        {
            MakeFakeObjects().ForEach(t => _fakeDbSet.Add(t));

            int count = 0;
            var result = _repository.FindBy(t => true, t => t.Id, 2, 2, ref count).ToList();
            
            Assert.AreEqual(5, count);
            Assert.AreEqual("Test Name 3", result[0].Name);
            Assert.AreEqual("Test Name 4", result[1].Name);
        }

        [Test]
        public void ShouldFindByPaginationOrderByDesc()
        {
            MakeFakeObjects().ForEach(t => _fakeDbSet.Add(t));

            int count = 0;
            var result = _repository.FindBy(t => true, t => t.Id, OrderByType.DESC, 2, 2, ref count).ToList();
            
            Assert.AreEqual(5, count);
            Assert.AreEqual("Test Name 3", result[0].Name);
            Assert.AreEqual("Test Name 2", result[1].Name);
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

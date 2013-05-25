using System;
using AdventureWorks.DataAccess;
using AdventureWorks.DataAccess.UnitOfWork;
using NUnit.Framework;
using Moq;

namespace AdventureWorks.UnitTest
{
    [TestFixture]
    public class UnitOfWorkTest
    {
        private Mock<IDbContext> _mockDbContext;
        private Mock<IUnitOfWorkRepository<object>> _mockUnitOfWorkRepository;
        private EFUnitOfWork _testUnitOfWork;
        private object _testEntity;

        [SetUp]
        public void SetUp()
        {
            _mockDbContext = new Mock<IDbContext>();
            _mockUnitOfWorkRepository = new Mock<IUnitOfWorkRepository<object>>();

            _testUnitOfWork = new EFUnitOfWork(_mockDbContext.Object);
            _testEntity = new object();
        }

        [Test]
        public void ShouldPersistCreationWhenRegisterNew()
        {
            _testUnitOfWork.RegisterNew(_testEntity, _mockUnitOfWorkRepository.Object);
            _mockUnitOfWorkRepository.Verify(t => t.PersistCreation(_testEntity));
        }

        [Test]
        public void ShouldPersistUpdateWhenRegisterChanged()
        {
            _testUnitOfWork.RegisterChanged(_testEntity, _mockUnitOfWorkRepository.Object);
            _mockUnitOfWorkRepository.Verify(t => t.PersistUpdate(_testEntity));
        }

        [Test]
        public void ShouldPersistDeletionWhenRegisterDeleted()
        {
            _testUnitOfWork.RegisterDeleted(_testEntity, _mockUnitOfWorkRepository.Object);
            _mockUnitOfWorkRepository.Verify(t => t.PersistDeletion(_testEntity));
        }

        [Test]
        public void ShouldSaveChangesWhenCommit()
        {
            _testUnitOfWork.Commit();
            _mockDbContext.Verify(t => t.SaveChanges());
        }

        [Test]
        public void ShouldRollbackWhenCommitFailed()
        {
            _mockDbContext.Setup(t => t.SaveChanges()).Throws(new ApplicationException("Commit Failed"));
            try
            {
                _testUnitOfWork.Commit();
            }
            catch (Exception)
            {
                _mockDbContext.Verify(t => t.Rollback());
            }
        }
    }
}

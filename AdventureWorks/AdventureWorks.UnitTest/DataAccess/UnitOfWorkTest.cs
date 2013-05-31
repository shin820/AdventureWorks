using System;
using AdventureWorks.DataAccess;
using AdventureWorks.DataAccess.UnitOfWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AdventureWorks.UnitTest.DataAccess
{
    [TestClass]
    public class UnitOfWorkTest
    {
        private Mock<IDbContext> _mockDbContext;
        private Mock<IUnitOfWorkRepository<object>> _mockUnitOfWorkRepository;
        private EFUnitOfWork _testUnitOfWork;
        private object _testEntity;

        [TestInitialize]
        public void SetUp()
        {
            _mockDbContext = new Mock<IDbContext>();
            _mockUnitOfWorkRepository = new Mock<IUnitOfWorkRepository<object>>();

            _testUnitOfWork = new EFUnitOfWork(_mockDbContext.Object);
            _testEntity = new object();
        }

        [TestMethod]
        public void ShouldPersistCreationWhenRegisterNew()
        {
            _testUnitOfWork.RegisterNew(_testEntity, _mockUnitOfWorkRepository.Object);
            _mockUnitOfWorkRepository.Verify(t => t.PersistCreation(_testEntity));
        }

        [TestMethod]
        public void ShouldPersistUpdateWhenRegisterChanged()
        {
            _testUnitOfWork.RegisterChanged(_testEntity, _mockUnitOfWorkRepository.Object);
            _mockUnitOfWorkRepository.Verify(t => t.PersistUpdate(_testEntity));
        }

        [TestMethod]
        public void ShouldPersistDeletionWhenRegisterDeleted()
        {
            _testUnitOfWork.RegisterDeleted(_testEntity, _mockUnitOfWorkRepository.Object);
            _mockUnitOfWorkRepository.Verify(t => t.PersistDeletion(_testEntity));
        }

        [TestMethod]
        public void ShouldSaveChangesWhenCommit()
        {
            _testUnitOfWork.Commit();
            _mockDbContext.Verify(t => t.SaveChanges());
        }

        [TestMethod]
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

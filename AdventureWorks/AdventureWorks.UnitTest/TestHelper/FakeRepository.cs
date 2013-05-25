using AdventureWorks.DataAccess;
using AdventureWorks.DataAccess.Repositories;
using AdventureWorks.DataAccess.UnitOfWork;

namespace AdventureWorks.UnitTest.TestHelper
{
    public class FakeRepository : Repository<FakeObject>
    {
        public FakeRepository(IDbContext dbContext, IUnitOfWork unitOfWork)
            : base(dbContext, unitOfWork)
        {

        }
    }
}
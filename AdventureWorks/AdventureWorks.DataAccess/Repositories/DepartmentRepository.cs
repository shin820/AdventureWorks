using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.DataAccess.UnitOfWork;
using AdventureWorks.Model.HumanResources;

namespace AdventureWorks.DataAccess.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(IDbContext dbContext, IUnitOfWork unitOfWork)
            : base(dbContext, unitOfWork)
        {

        }
    }
}

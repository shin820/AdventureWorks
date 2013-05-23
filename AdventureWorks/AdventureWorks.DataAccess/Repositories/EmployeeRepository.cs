using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.DataAccess.Repositories.Interfaces;

namespace AdventureWorks.DataAccess.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        public override void Delete(Employee entity)
        {
            entity.CurrentFlag = false;
            Update(entity);
        }
    }
}

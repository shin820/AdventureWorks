using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.DataAccess.Interfaces;

namespace AdventureWorks.DataAccess.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DbContext context)
            : base(context)
        {

        }
    }
}

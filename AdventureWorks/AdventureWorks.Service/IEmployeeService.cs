using System.Collections.Generic;
using AdventureWorks.Service.ViewModel;

namespace AdventureWorks.Service
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeViewModel> GetEmployees();
        EmployeeListViewModel GetEmployees(int pageIndex, int pageSize);
    }
}
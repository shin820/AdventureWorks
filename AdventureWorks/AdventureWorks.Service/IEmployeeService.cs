using System.Collections.Generic;
using AdventureWorks.Model.HumanResources;

namespace AdventureWorks.Service
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees(int pageIndex, int pageSize, out int count);
        Employee GetEmployee(int employeeId);
        void UpdateEmployee(Employee employee);
    }
}
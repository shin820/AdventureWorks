using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.Model.HumanResources;
using System.Data.Entity;
using AdventureWorks.DataAccess.UnitOfWork;

namespace AdventureWorks.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IEmployeeRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public List<Employee> GetEmployees(int pageIndex, int pageSize, out int count)
        {
            count = _repository.FindAll().Count(t => t.CurrentFlag);

            var employees =
                _repository.FindBy(t => t.CurrentFlag, t => t.LoginId, pageIndex, pageSize, ref count)
                           .Include(t => t.Contact)
                           .Include(t => t.Manager.Contact);
            

            return employees.ToList();
        }

        public Employee GetEmployee(int employeeId)
        {
            return _repository.FindBy(t => t.CurrentFlag && t.EmployeeId == employeeId).SingleOrDefault();
        }


        public void UpdateEmployee(Employee employee)
        {
            _repository.Update(employee);
            _unitOfWork.Commit();
        }
    }
}

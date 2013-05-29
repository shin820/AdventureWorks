using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.Model.HumanResources;
using System.Data.Entity;
using AdventureWorks.Service.ViewModel;

namespace AdventureWorks.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<EmployeeViewModel> GetEmployees()
        {
            var employees = from e in _repository.FindAll().Include(t => t.Contact).Include(t => t.Manager.Contact)
                            where e.CurrentFlag
                            select e;

            return from e in employees.AsEnumerable()
                   select new EmployeeViewModel
                       {
                           EmployeeId = e.EmployeeId,
                           LoginId = e.LoginId,
                           NationalIdNumber = e.NationalIdNumber,
                           Name = e.Contact.FullName,
                           Email = e.Contact.EmailAddress,
                           Phone = e.Contact.Phone,
                           Title = e.Title,
                           ManagerId = e.ManagerId ?? 0,
                           ManagerName = e.Manager.Contact.FullName,
                           BirthDate = e.BirthDate.ToString("yyyy-MM-dd"),
                           MaritalStatus = e.MaritalStatus == "M" ? "已婚" : "未婚",
                           Gender = e.Gender == "M" ? "男" : "女",
                           HireDate = e.HireDate.ToString("yyyy-MM-dd")
                       };
        }

        public EmployeeListViewModel GetEmployees(int pageIndex, int pageSize)
        {
            var employees = _repository.FindAll().Include(t => t.Contact).Include(t => t.Manager.Contact)
                                       .Where(t => t.CurrentFlag)
                                       .OrderBy(t => t.LoginId)
                                       .Skip((pageIndex - 1)*pageSize)
                                       .Take(pageSize);

            return new EmployeeListViewModel
                {
                    Employees = from e in employees.AsEnumerable()
                                select new EmployeeViewModel
                                    {
                                        EmployeeId = e.EmployeeId,
                                        LoginId = e.LoginId,
                                        NationalIdNumber = e.NationalIdNumber,
                                        Name = e.Contact.FullName,
                                        Email = e.Contact.EmailAddress,
                                        Phone = e.Contact.Phone,
                                        Title = e.Title,
                                        ManagerId = e.ManagerId ?? 0,
                                        ManagerName = e.Manager.Contact.FullName,
                                        BirthDate = e.BirthDate.ToString("yyyy-MM-dd"),
                                        MaritalStatus = e.MaritalStatus == "M" ? "已婚" : "未婚",
                                        Gender = e.Gender == "M" ? "男" : "女",
                                        HireDate = e.HireDate.ToString("yyyy-MM-dd")
                                    },
                    PageInfo = new PageInfo
                        {
                            CurrentPage = pageIndex,
                            ItemsPerPage = pageSize,
                            TotalItems = _repository.FindAll().Count(t => t.CurrentFlag)
                        }

                };

        }
    }
}

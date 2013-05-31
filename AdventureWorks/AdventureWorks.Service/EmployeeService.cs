using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.Model.HumanResources;
using System.Data.Entity;

namespace AdventureWorks.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public List<Employee> GetEmployees(int pageIndex, int pageSize, out int count )
        {
            count = _repository.FindAll().Count(t => t.CurrentFlag);

            var employees =
                _repository.FindBy(t => t.CurrentFlag, t => t.LoginId, pageIndex, pageSize, ref count)
                           .Include(t => t.Contact)
                           .Include(t => t.Manager.Contact);

            return employees.ToList();

            //return new EmployeeListViewModel
            //    {
            //        Employees = from e in employees.AsEnumerable()
            //                    select new EmployeeViewModel
            //                        {
            //                            EmployeeId = e.EmployeeId,
            //                            LoginId = e.LoginId,
            //                            NationalIdNumber = e.NationalIdNumber,
            //                            Name = e.Contact.FullName,
            //                            Email = e.Contact.EmailAddress,
            //                            Phone = e.Contact.Phone,
            //                            Title = e.Title,
            //                            ManagerId = e.ManagerId ?? 0,
            //                            ManagerName = e.Manager.Contact.FullName,
            //                            BirthDate = e.BirthDate.ToString("yyyy-MM-dd"),
            //                            MaritalStatus = e.MaritalStatus == "M" ? "已婚" : "未婚",
            //                            Gender = e.Gender == "M" ? "男" : "女",
            //                            HireDate = e.HireDate.ToString("yyyy-MM-dd")
            //                        },
            //        PageInfo = new PageInfo
            //            {
            //                CurrentPage = pageIndex,
            //                ItemsPerPage = pageSize,
            //                TotalItems = _repository.FindAll().Count(t => t.CurrentFlag)
            //            }

            //    };

        }

        //public EmployeeListViewModel GetEmployees(int pageIndex, int pageSize)
        //{
        //    int count = 0;
        //    var employees =
        //        _repository.FindBy(t => t.CurrentFlag, t => t.LoginId, pageIndex, pageSize, ref count)
        //                   .Include(t => t.Contact)
        //                   .Include(t => t.Manager.Contact);

        //    return new EmployeeListViewModel
        //        {
        //            Employees = from e in employees.AsEnumerable()
        //                        select new EmployeeViewModel
        //                            {
        //                                EmployeeId = e.EmployeeId,
        //                                LoginId = e.LoginId,
        //                                NationalIdNumber = e.NationalIdNumber,
        //                                Name = e.Contact.FullName,
        //                                Email = e.Contact.EmailAddress,
        //                                Phone = e.Contact.Phone,
        //                                Title = e.Title,
        //                                ManagerId = e.ManagerId ?? 0,
        //                                ManagerName = e.Manager.Contact.FullName,
        //                                BirthDate = e.BirthDate.ToString("yyyy-MM-dd"),
        //                                MaritalStatus = e.MaritalStatus == "M" ? "已婚" : "未婚",
        //                                Gender = e.Gender == "M" ? "男" : "女",
        //                                HireDate = e.HireDate.ToString("yyyy-MM-dd")
        //                            },
        //            PageInfo = new PageInfo
        //                {
        //                    CurrentPage = pageIndex,
        //                    ItemsPerPage = pageSize,
        //                    TotalItems = _repository.FindAll().Count(t => t.CurrentFlag)
        //                }

        //        };

        //}
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.Service;
using AdventureWorks.WebUI.MVC.Models;
using Microsoft.Practices.Unity;

namespace AdventureWorks.WebUI.MVC.Controllers
{
    public class EmployeeController:Controller
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        public ViewResult Details(int page = 1)
        {
            int count;
            List<Employee> employees = _service.GetEmployees(page, 20, out count);

            var model = new EmployeeListViewModel
                {
                    Employees = from e in employees
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
                            CurrentPage = page,
                            ItemsPerPage = 20,
                            TotalItems = count
                        }

                };

            return View(model);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web.Mvc;
using AdventureWorks.DataAccess.UnitOfWork;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.Service;
using AdventureWorks.WebUI.MVC.Models;
using Microsoft.Practices.Unity;

namespace AdventureWorks.WebUI.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;
        private const int PAGE_SIZE = 20;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        public ViewResult Details(int page = 1)
        {
            int count;
            List<Employee> employees = _service.GetEmployees(page, PAGE_SIZE, out count);

            var model = new EmployeeListViewModel
                {
                    Employees = employees.Select((e, index) => new EmployeeViewModel
                        {
                            RowNumber = index + 1 + (page - 1)*PAGE_SIZE,
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
                            MaritalStatus = e.MaritalStatus,
                            Gender = e.Gender,
                            HireDate = e.HireDate.ToString("yyyy-MM-dd")
                        }),
                    PageInfo = new PageInfo
                        {
                            CurrentPage = page,
                            ItemsPerPage = PAGE_SIZE,
                            TotalItems = count
                        }

                };

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            Employee employee = _service.GetEmployee(id);
            EmployeeEditViewModel employeeEditViewModel = new EmployeeEditViewModel
                {
                    EmployeeId = employee.EmployeeId,
                    NationalIdNumber = employee.NationalIdNumber,
                    LoginId = employee.LoginId,
                    Title = employee.Title,
                    BirthDate = employee.BirthDate,
                    MaritalStatus = employee.MaritalStatus,
                    Gender = employee.Gender,
                    HireDate = employee.HireDate,
                    SalariedFlag = employee.SalariedFlag
                };

            return View(employeeEditViewModel);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SaveEmployee(model);
                    return RedirectToAction("Details");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return View(model);
        }

        private void SaveEmployee(EmployeeEditViewModel viewModel)
        {
            Employee employee = _service.GetEmployee(viewModel.EmployeeId);
            employee.NationalIdNumber = viewModel.NationalIdNumber;
            employee.Title = viewModel.Title;
            employee.BirthDate = viewModel.BirthDate;
            employee.MaritalStatus = viewModel.MaritalStatus;
            employee.Gender = viewModel.Gender;
            employee.SalariedFlag = viewModel.SalariedFlag;
            _service.UpdateEmployee(employee);
        }

        private SelectList CreateSelectList<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs,
                                                          object selectedValue)
        {
            return new SelectList(keyValuePairs, "Value", "Key", selectedValue);
        }
    }
}
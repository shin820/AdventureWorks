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
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeController(IEmployeeService service, IUnitOfWork unitOfWork)
        {
            _service = service;
            _unitOfWork = unitOfWork;
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
                                        //MaritalStatus = e.MaritalStatus == "M" ? "已婚" : "未婚",
                                        //Gender = e.Gender == "M" ? "男" : "女",
                                        MaritalStatus = e.MaritalStatus,
                                        Gender = e.Gender,
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

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            Employee employee = _service.GetEmployee(id);
            SetViewBag(employee);

            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee model)
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

            SetViewBag(model);
            return View(model);
        }

        private void SaveEmployee(Employee emp)
        {
            Employee employee = _service.GetEmployee(emp.EmployeeId);
            employee.NationalIdNumber = emp.NationalIdNumber;
            employee.Title = emp.Title;
            employee.BirthDate = emp.BirthDate;
            employee.MaritalStatus = emp.MaritalStatus;
            employee.Gender = emp.Gender;
            employee.SalariedFlag = emp.SalariedFlag;
            _service.RegisterToSave(employee);
            _unitOfWork.Commit();
        }

        private void SetViewBag(Employee employee)
        {
            var martialList = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("已婚", "M"),
                    new KeyValuePair<string, string>("未婚", "S")
                };
            ViewBag.MaritalStatusList = CreateSelectList(martialList, employee.MaritalStatus);

            var genderList = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("男性", "M"),
                    new KeyValuePair<string, string>("女性", "F")
                };
            ViewBag.GenderList = CreateSelectList(genderList, employee.Gender);

            var salaryType = new List<KeyValuePair<string, bool>>
                {
                    new KeyValuePair<string, bool>("计时", false),
                    new KeyValuePair<string, bool>("月薪", true)
                };
            ViewBag.SalaryTypeList = CreateSelectList(salaryType, employee.SalariedFlag);
        }

        private SelectList CreateSelectList<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs,
                                                          object selectedValue)
        {
            return new SelectList(keyValuePairs, "Value", "Key", selectedValue);
        }
    }
}
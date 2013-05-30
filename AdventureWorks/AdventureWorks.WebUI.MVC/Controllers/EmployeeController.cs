using System.Collections.Generic;
using System.Web.Mvc;
using AdventureWorks.Service;
using AdventureWorks.Service.ViewModel;
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
            return View(_service.GetEmployees(page, 20));
        }
    }
}
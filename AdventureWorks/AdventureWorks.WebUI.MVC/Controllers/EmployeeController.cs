using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdventureWorks.DataAccess;
using AdventureWorks.DataAccess.Repositories;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.DataAccess.UnitOfWork;
using AdventureWorks.Service;
using AdventureWorks.Service.ViewModel;

namespace AdventureWorks.WebUI.MVC.Controllers
{
    public class EmployeeController:Controller
    {
        private readonly IEmployeeService _service;

        public EmployeeController()
        {
            IDbContext context = new AdventureWorksContext("AdventureWorks");
            IUnitOfWork unitOfWork = new EFUnitOfWork(context);
            IEmployeeRepository repository = new EmployeeRepository(context, unitOfWork);
            _service = new EmployeeService(repository);
        }


        public ActionResult Details()
        {
            IEnumerable<EmployeeViewModel> employees = _service.GetEmployees();
            return View(employees);
        }
    }
}
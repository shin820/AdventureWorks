using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.Model.Person;
using AdventureWorks.Service;
using AdventureWorks.WebUI.MVC.Controllers;
using AdventureWorks.WebUI.MVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AdventureWorks.UnitTest.Controllers
{
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestMethod]
        public void ShouldReturnModelToDetailsView()
        {
            var controller = new EmployeeController(new FakeEmployeeService(), null);

            EmployeeListViewModel model = controller.Details(2).Model as EmployeeListViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual(20, model.Employees.Count());
            Assert.AreEqual(2, model.PageInfo.CurrentPage);
            Assert.AreEqual(20, model.PageInfo.TotalItems);
        }

        private class FakeEmployeeService : IEmployeeService
        {
            public List<Employee> GetEmployees(int pageIndex, int pageSize, out int count)
            {
                List<Employee> employees = new List<Employee>();

                for (int i = 0; i < 20; i++)
                {
                    employees.Add(new Employee
                        {
                            EmployeeId = i,
                            LoginId = "test/test" + i,
                            NationalIdNumber = "0000",
                            Contact = new Person_Contact
                                {
                                    FirstName = "fName",
                                    LastName = "lName",
                                    EmailAddress = "test@test.com",
                                    Phone = "11223344"
                                },
                            Title = "test_title" + i,
                            ManagerId = 2 + i,
                            Manager = new Employee
                                {
                                    EmployeeId = 2 + i,
                                    Contact = new Person_Contact
                                        {
                                            FirstName = "fName_Manager",
                                            LastName = "lName_Manager"
                                        }
                                },
                            CurrentFlag = true,
                            BirthDate = DateTime.Now.AddYears(-20),
                            MaritalStatus = "M",
                            Gender = "M",
                            HireDate = DateTime.Now
                        });
                }

                count = employees.Count;

                return employees;
            }


            public Employee GetEmployee(int employeeId)
            {
                throw new NotImplementedException();
            }


            public void RegisterToSave(Employee employee)
            {
                throw new NotImplementedException();
            }
        }
    }
}

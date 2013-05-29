using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.Model.Person;
using AdventureWorks.Service;
using NUnit.Framework;
using Moq;

namespace AdventureWorks.UnitTest
{
    public class EmployeeServiceTest
    {
        [Test]
        public void ShouldReturnEmployees()
        {
            var mockRepository = new Mock<IEmployeeRepository>();
            var testEmployee = new Employee
                {
                    EmployeeId = 1,
                    LoginId = "test/test1",
                    NationalIdNumber = "0000",
                    Contact = new Person_Contact
                        {
                            FirstName = "fName",
                            LastName = "lName",
                            EmailAddress = "test@test.com",
                            Phone = "11223344"
                        },
                    Title = "test_title",
                    ManagerId = 2,
                    Manager = new Employee
                        {
                            EmployeeId = 2,
                            Contact = new Person_Contact
                                {
                                    FirstName = "fName_Manager",
                                    LastName = "lName_Manager"
                                }
                        },
                    BirthDate = DateTime.Now.AddYears(-20),
                    MaritalStatus = "M",
                    Gender = "M",
                    HireDate = DateTime.Now
                };
            mockRepository.Setup(t => t.FindAll()).Returns(new List<Employee>
                {
                    testEmployee
                }.AsQueryable);

            EmployeeService service = new EmployeeService(mockRepository.Object);

            var result = service.GetEmployees().First();
            Assert.AreEqual(testEmployee.EmployeeId, result.EmployeeId);
            Assert.AreEqual(testEmployee.LoginId, result.LoginId);
            Assert.AreEqual(testEmployee.NationalIdNumber, result.NationalIdNumber);
            string expectedName = testEmployee.Contact.FirstName + " " + testEmployee.Contact.LastName;
            Assert.AreEqual(expectedName, result.Name);
            Assert.AreEqual(testEmployee.Contact.EmailAddress, result.Email);
            Assert.AreEqual(testEmployee.Contact.Phone, result.Phone);
            Assert.AreEqual(testEmployee.Title, result.Title);
            Assert.AreEqual(testEmployee.EmployeeId, result.EmployeeId);
            string expectedManagerName = testEmployee.Manager.Contact.FirstName + " " +
                                         testEmployee.Manager.Contact.LastName;
            Assert.AreEqual(expectedManagerName, result.ManagerName);
            Assert.AreEqual("男", result.Gender);
            Assert.AreEqual("已婚", result.MaritalStatus);
            Assert.AreEqual(testEmployee.BirthDate.ToString("yyyy-MM-dd"), result.BirthDate);
            Assert.AreEqual(testEmployee.HireDate.ToString("yyyy-MM-dd"), result.HireDate);


        }
    }
}

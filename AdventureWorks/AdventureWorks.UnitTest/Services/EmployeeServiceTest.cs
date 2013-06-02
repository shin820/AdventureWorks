using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AdventureWorks.DataAccess.Repositories.Enum;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.Model.Person;
using AdventureWorks.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AdventureWorks.UnitTest.Services
{
    [TestClass]
    public class EmployeeServiceTest
    {
        [TestMethod]
        public void ShouldReturnEmployees()
        {
            EmployeeService service = new EmployeeService(new FakeEmployeeRepository(), null);
            int count;
            var result = service.GetEmployees(1, 10, out count).First();
            Assert.AreEqual(1, count);
            Assert.IsNotNull(result);
        }

        private class FakeEmployeeRepository:IEmployeeRepository 
        {
            public IQueryable<Employee> FindAll()
            {
                return new List<Employee>
                    {
                        new Employee
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
                                CurrentFlag = true,
                                BirthDate = DateTime.Now.AddYears(-20),
                                MaritalStatus = "M",
                                Gender = "M",
                                HireDate = DateTime.Now
                            },
                        new Employee
                            {
                                EmployeeId = 2,
                                LoginId = "test/test2",
                                CurrentFlag = false
                            }
                    }.AsQueryable();
            }

            public IQueryable<Employee> FindBy(Expression<Func<Employee, bool>> filter)
            {
                throw new NotImplementedException();
            }

            public IQueryable<Employee> FindBy<TKey>(Expression<Func<Employee, bool>> filter,
                                                     Expression<Func<Employee, TKey>> @orderby, int pageIndex,
                                                     int pageSize, ref int count)
            {
                return FindAll();
            }

            public IQueryable<Employee> FindBy<TKey>(Expression<Func<Employee, bool>> filter, Expression<Func<Employee, TKey>> @orderby, OrderByType orderByType, int pageIndex, int pageSize,
                                           ref int count)
            {
                throw new NotImplementedException();
            }

            public void Add(Employee entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Employee entity)
            {
                throw new NotImplementedException();
            }

            public void Update(Employee entity)
            {
                throw new NotImplementedException();
            }


            public Employee FindBy(int id)
            {
                throw new NotImplementedException();
            }
        }
    }
}

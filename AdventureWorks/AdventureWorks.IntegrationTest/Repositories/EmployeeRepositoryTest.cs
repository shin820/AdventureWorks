using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.DataAccess;
using AdventureWorks.DataAccess.Repositories;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.DataAccess.UnitOfWork;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.Model.Person;
using NUnit.Framework;

namespace AdventureWorks.IntegrationTest.Repositories
{
    public class EmployeeRepositoryTest : RepositoryTestBase<Employee>
    {
        private const string TEST_EMPLOYEE_TITLE = "TEST_EMPLOYEE_TITLE";
        private IEmployeeRepository _repository;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _repository = new EmployeeRepository(Context, new EFUnitOfWork(Context));
        }

        [Test]
        public void ShouldGetEmployeeAdresses()
        {
            AddTestEntities();
            Employee added = GetTestEntity();
            Assert.Greater(added.Addresses.Count, 0);
        }

        [Test]
        public void ShouldGetEmployeeContact()
        {
            AddTestEntities();
            Employee added = GetTestEntity();
            Assert.IsNotNull(added.Contact);
        }

        protected override IRepository<Employee> GetRepository()
        {
            return _repository;
        }

        protected override Expression<Func<Employee, bool>> IdentifyTestEntityExpression()
        {
            var employeeParam = Expression.Parameter(typeof (Employee), "employee");

            return Expression.Lambda<Func<Employee, bool>>(
                Expression.And(
                    Expression.Equal(
                        Expression.Property(employeeParam, typeof (Employee).GetProperty("Title")),
                        Expression.Constant(TEST_EMPLOYEE_TITLE, typeof (string))
                        ),
                    Expression.Equal(
                        Expression.Property(employeeParam, typeof (Employee).GetProperty("CurrentFlag")),
                        Expression.Constant(true, typeof (bool))
                        )
                    ),
                new ParameterExpression[] {employeeParam}
                );
        }

        protected override Employee MakeTestEntity()
        {
            Employee employee = new Employee
                {
                    NationalIdNumber = DateTime.Now.ToString("hh24mmssfff"),
                    LoginId = "TEST_" + DateTime.Now.ToString("yyyyMMddhh24mmssfff"),
                    Title = TEST_EMPLOYEE_TITLE,
                    BirthDate = DateTime.Now.AddYears(-28),
                    MaritalStatus = "M",
                    Gender = "M",
                    HireDate = DateTime.Now.AddYears(-5),
                    Contact = new Person_Contact
                        {
                            FirstName = "TEST_FIRST_NAME",
                            LastName = "TEST_LAST_NAME",
                            PasswordHash = "TEST_HASH",
                            PasswordSalt = "TEST_SALT",
                        }
                };

            employee.Addresses.Add(new Address
                {
                    AddressLine1 = "TEST_ADDRESS_" + DateTime.Now.ToString("yyyyMMddhh24mmssfff"),
                    City = "TEST_CITY",
                    StateProvinceId = 79,
                    PostalCode = "111111",
                });

            return employee;
        }

        protected override void AssertEntitiesAreEqual(Employee expected, Employee actual)
        {
            Assert.AreEqual(expected.VacationHours, actual.VacationHours);
            Assert.AreEqual(expected.SickLeaveHours, actual.SickLeaveHours);
            Assert.AreEqual(expected.Contact.FirstName, actual.Contact.FirstName);
            Assert.AreEqual(expected.Contact.LastName, actual.Contact.LastName);
        }

        protected override void ChangePeroperties(Employee entity)
        {
            entity.VacationHours = 100;
            entity.SickLeaveHours = 20;
            entity.Contact.FirstName = "TEST_FIRST_NAME_UPDATE";
            entity.Contact.LastName = "TEST_LAST_NAME_UPDATE";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AdventureWorks.Model.HumanResources;

namespace AdventureWorks.IntegrationTest
{
    public class EmployeeConfigurationTest : IntegrationTestBase
    {
        private Employee _testEmployee;

        [TestFixtureSetUp]
        public void EmployeeConfigurationTestSetUp()
        {
            _testEmployee = adventureWorksContext.Set<Employee>().FirstOrDefault();
        }

        [Test]
        public void ShouldGetEmployee()
        {
            Assert.IsNotNull(_testEmployee);
            Assert.Greater(_testEmployee.EmployeeId, 0);
        }

        [Test]
        public void ShouldDisableLazyLoading()
        {
            var employee = adventureWorksContext.Set<Employee>().FirstOrDefault();
            Assert.IsNull(employee.Manager);
            Assert.IsNull(employee.Contact);
        }

        [Test]
        public void ShouldGetManagerByExplicitLoad()
        {
            adventureWorksContext.Entry(_testEmployee).Reference(e => e.Manager).Load();
            Assert.IsNotNull(_testEmployee.Manager);
        }

        [Test]
        public void ShouldGetContactByExplicitLoad()
        {
            adventureWorksContext.Entry(_testEmployee).Reference(e => e.Contact).Load();
            Assert.IsNotNull(_testEmployee.Contact);
        }
    }
}

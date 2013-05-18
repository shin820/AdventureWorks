using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NUnit.Framework;

namespace AdventureWorks.IntegrationTest
{
    [TestFixture]
    public class AdventureWorksContextTest : IntegrationTestBase
    {
        [Test]
        public void ShouldGetEntity()
        {
            var employee = adventureWorksContext.HumanResources_Employee.FirstOrDefault();

            Assert.IsNotNull(employee);
        }
    }
}

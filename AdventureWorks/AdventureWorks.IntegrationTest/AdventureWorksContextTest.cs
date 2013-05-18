using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AdventureWorks.Model;
using AdventureWorks.Model.HumanResources;
using NUnit.Framework;
using AdventureWorks.DataAccess;

namespace AdventureWorks.IntegrationTest
{
    [TestFixture]
    public class AdventureWorksContextTest : IntegrationTestBase
    {
        [Test]
        public void ShouldGetEntity()
        {
            var employee = adventureWorksContext.Set<Employee>().FirstOrDefault();

            Assert.IsNotNull(employee);
        }

        [Test]
        public void ShouldReturnEntityImplementedIObjectWithState()
        {
            Assert.IsFalse(adventureWorksContext.Set<Employee>().AsEnumerable().Any(e => !(e is ObjectWithState)));
        }
    }
}

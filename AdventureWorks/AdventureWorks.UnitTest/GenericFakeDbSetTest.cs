using System.Linq;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.UnitTest.TestHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.UnitTest
{
    [TestClass]
    public class GenericFakeDbSetTest
    {
        [TestMethod]
        public void FindTest()
        {
            var fake = FakeDbSetBuilder.New<Employee>().Build(t => t.EmployeeId);
            fake.Add(new Employee {EmployeeId = 1, Title = "Alice"});
            fake.Add(new Employee {EmployeeId = 2, Title = "Bob"});

            var result = fake.Find(2);

            Assert.AreEqual("Bob", result.Title);
        }

        [TestMethod]
        public void AddTest()
        {
            var fake = FakeDbSetBuilder.New<Employee>().Build(t => t.EmployeeId);
            fake.Add(new Employee {Title = "Alice"});
            fake.Add(new Employee {Title = "Bob"});

            var result = fake.Count();

            Assert.AreEqual(2, result);
        }
    }
}

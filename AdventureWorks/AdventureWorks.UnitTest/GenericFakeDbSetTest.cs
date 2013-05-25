using System.Linq;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.UnitTest.TestHelper;
using NUnit.Framework;

namespace AdventureWorks.UnitTest
{
    public class GenericFakeDbSetTest
    {
        [Test]
        public void FindTest()
        {
            var fake = FakeDbSetBuilder.New<Employee>().Build(t => t.EmployeeId);
            fake.Add(new Employee {EmployeeId = 1, Title = "Alice"});
            fake.Add(new Employee {EmployeeId = 2, Title = "Bob"});

            var result = fake.Find(2);

            Assert.AreEqual("Bob", result.Title);
        }

        [Test]
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

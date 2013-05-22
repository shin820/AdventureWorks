using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.DataAccess;
using AdventureWorks.DataAccess.Repositories;
using AdventureWorks.DataAccess.Interfaces;
using AdventureWorks.Model.HumanResources;
using NUnit.Framework;
using System.Linq.Expressions;

namespace AdventureWorks.IntegrationTest.Repositories
{
    [TestFixture]
    public class DepartmentRepositoryTest : RepositoryTestBase<Department>
    {
        private IDepartmentRepository repository;
        private const string TEST_DEPARTMENT_GROUP = "Test Group";

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            repository = new DepartmentRepository(context);
        }

        protected override IBaseRepository<Department> GetRepository()
        {
            return repository;
        }

        protected override void ChangePeroperties(Department department)
        {
            department.Name = "TEST UPDATE DEPARTMENT NAME";
        }

        protected override Expression<Func<Department, bool>> IdentifyTestEntityExpression()
        {
            var departmentParam = Expression.Parameter(typeof (Department), "department");

            return Expression.Lambda<Func<Department, bool>>(
                Expression.Equal(
                    Expression.Property(departmentParam, typeof (Department).GetProperty("GroupName")),
                    Expression.Constant(TEST_DEPARTMENT_GROUP, typeof (string))),
                new ParameterExpression[] {departmentParam});
        }

        protected override Department MakeTestEntity()
        {
            return new Department
                {
                    Name = "Test Department",
                    GroupName = TEST_DEPARTMENT_GROUP,
                    ModifiedDate = DateTime.Now
                };
        }

        protected override void AssertEntitiesAreEqual(Department expected, Department actual)
        {
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.GroupName, actual.GroupName);
            Assert.AreEqual(expected.ModifiedDate.ToShortDateString(), actual.ModifiedDate.ToShortDateString());
        }
    }
}

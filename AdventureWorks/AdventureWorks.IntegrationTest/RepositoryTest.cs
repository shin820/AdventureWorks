using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.DataAccess;
using AdventureWorks.Model;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.Model.Person;
using AdventureWorks.Model.Sales;
using NUnit.Framework;

namespace AdventureWorks.IntegrationTest
{
    public class RepositoryTest : IntegrationTestBase
    {
        private IRepository repository;

        [SetUp]
        public void Setup()
        {
            repository = new Repository(adventureWorksContext);
        }

        [Test]
        public void ShouldAddDepartment()
        {
            AddTestDepartments();
            var departments = GetTestDepartments();
            Assert.AreEqual(2, departments.Count());
            DeleteTestDepartments();
        }

        [Test]
        public void ShouldUpdateDepartment()
        {
            AddTestDepartments();
            const string UpdatedName = "Test Department 3";
            Department department = GetTestDepartments().FirstOrDefault();
            department.Name = UpdatedName;
            repository.Update(department);

            Department updatedDepartment =
                repository.Query<Department>(d => d.Name == UpdatedName).FirstOrDefault();

            Assert.IsNotNull(updatedDepartment);
            DeleteTestDepartments();
        }

        [Test]
        public void ShouldDeleteDepartment()
        {
            AddTestDepartments();
            Department department = GetTestDepartments().FirstOrDefault();
            repository.Delete<Department>(department);

            Assert.AreEqual(1, GetTestDepartments().Count());
            DeleteTestDepartments();
        }

        [Test]
        public void ShouldAddEntityGraphy()
        {
            AddTestStateProvinces();

            StateProvince stateProvince = repository.Query<StateProvince>(t => t.Name == "TEST_STATE_PROVINCE").Single();
            Assert.IsNotNull(stateProvince);
            Assert.IsNotNull(stateProvince.CountryRegion);
            Assert.IsNotNull(stateProvince.Sales_SalesTerritory);

            DeleteStateProvince();
        }

        private IQueryable<Department> GetTestDepartments()
        {
            return repository.Query<Department>(d => d.GroupName == "Test Group");
        }

        private void AddTestDepartments()
        {
            Department department1 = new Department
                {
                    Name = "Test Department1",
                    GroupName = "Test Group",
                    ModifiedDate = DateTime.Now
                };

            Department department2 = new Department
                {
                    Name = "Test Department2",
                    GroupName = "Test Group",
                    ModifiedDate = DateTime.Now
                };

            repository.Add<Department>(department1);
            repository.Add<Department>(department2);
        }

        private void DeleteTestDepartments()
        {
            var departments = GetTestDepartments().ToList();
            departments.ForEach(d => repository.Delete(d));
        }

        private void AddTestStateProvinces()
        {
            StateProvince stateProvince = new StateProvince
                {
                    StateProvinceCode = "XXX",
                    IsOnlyStateProvinceFlag = false,
                    Name = "TEST_STATE_PROVINCE",
                    Rowguid = Guid.NewGuid(),
                    ModifiedDate = DateTime.Now,
                    State = State.Added,
                    CountryRegion = new CountryRegion
                        {
                            CountryRegionCode = "XXX",
                            Name = "TEST_CONTRY_REGION",
                            ModifiedDate = DateTime.Now,
                            State = State.Added
                        },
                    Sales_SalesTerritory = new SalesTerritory
                        {
                            Name = "TEST_TERRITORY",
                            CountryRegionCode = "XXX",
                            Group = "TEST_GROUP",
                            SalesYtd = 100,
                            CostYtd = 111,
                            CostLastYear = 222,
                            Rowguid = Guid.NewGuid(),
                            ModifiedDate = DateTime.Now,
                            State = State.Added
                        }
                };

            repository.SaveChanges(stateProvince);
        }

        private void DeleteStateProvince()
        {
            StateProvince stateProvince =
                repository.Query<StateProvince>(t => t.Name == "TEST_STATE_PROVINCE").Single();

            stateProvince.State = State.Deleted;
            stateProvince.CountryRegion.State = State.Deleted;
            stateProvince.Sales_SalesTerritory.State = State.Deleted;

            repository.SaveChanges(stateProvince);

        }
    }
}

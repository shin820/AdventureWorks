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
        private IRepository _repository;

        [SetUp]
        public void Setup()
        {
            _repository = new Repository(adventureWorksContext);
            DeleteTestDepartments();
            DeleteTestStateProvince();
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
            const string updatedName = "Test Department 3";
            Department department = GetTestDepartments().FirstOrDefault();
            Assert.IsNotNull(department);

            department.Name = updatedName;
            _repository.Update(department);

            Department updatedDepartment =
                _repository.Query<Department>(d => d.Name == updatedName).FirstOrDefault();

            Assert.IsNotNull(updatedDepartment);
            DeleteTestDepartments();
        }

        [Test]
        public void ShouldDeleteDepartment()
        {
            AddTestDepartments();
            Department department = GetTestDepartments().FirstOrDefault();
            _repository.Delete<Department>(department);

            Assert.AreEqual(1, GetTestDepartments().Count());
            DeleteTestDepartments();
        }

        [Test]
        public void ShouldAddEntityGraphy()
        {
            AddTestStateProvinces();

            StateProvince stateProvince = _repository.Query<StateProvince>(t => t.Name == "TEST_STATE_PROVINCE").Single();
            Assert.IsNotNull(stateProvince);
            Assert.IsNotNull(stateProvince.CountryRegion);
            Assert.IsNotNull(stateProvince.SalesTerritory);

            DeleteTestStateProvince();
        }

        private IQueryable<Department> GetTestDepartments()
        {
            return _repository.Query<Department>(d => d.GroupName == "Test Group");
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

            _repository.Add<Department>(department1);
            _repository.Add<Department>(department2);
        }

        private void DeleteTestDepartments()
        {
            var departments = GetTestDepartments().ToList();
            if (departments.Count > 0)
            {
                departments.ForEach(d => _repository.Delete(d));
            }
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
                    SalesTerritory = new SalesTerritory
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

            _repository.SaveChanges(stateProvince);
        }

        private void DeleteTestStateProvince()
        {
            StateProvince stateProvince =
                _repository.Query<StateProvince>(t => t.Name == "TEST_STATE_PROVINCE").SingleOrDefault();
            if (stateProvince == null) return;

            stateProvince.State = State.Deleted;
            stateProvince.CountryRegion.State = State.Deleted;
            stateProvince.SalesTerritory.State = State.Deleted;

            _repository.SaveChanges(stateProvince);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Model;
using AdventureWorks.WebUI.MVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.UnitTest.ViewModel
{
    [TestClass]
    public class EmployeeEditViewModelTest
    {
        [TestMethod]
        public void ShouldGetMartialStatusList()
        {
            var viewModel = new EmployeeEditViewModel();
            viewModel.MaritalStatus = DataDefinition.MartialStatus.UnMarried;

            Assert.AreEqual(DataDefinition.MartialStatus.UnMarried, viewModel.MartialStatusList.SelectedValue);
        }

        [TestMethod]
        public void ShouldGetGenderList()
        {
            var viewModel = new EmployeeEditViewModel();
            viewModel.Gender = DataDefinition.Gender.Female;

            Assert.AreEqual(DataDefinition.Gender.Female, viewModel.GenderList.SelectedValue);
        }

        [TestMethod]
        public void ShouldGetSalaryTypeList()
        {
            var viewModel = new EmployeeEditViewModel();
            viewModel.SalariedFlag = true;

            Assert.AreEqual(true, viewModel.SalaryTypeList.SelectedValue);
        }
    }
}

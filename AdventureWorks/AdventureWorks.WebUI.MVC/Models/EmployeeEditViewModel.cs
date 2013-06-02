using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorks.WebUI.MVC.Models
{
    public class EmployeeEditViewModel
    {
        public int EmployeeId { get; set; }
        public string NationalIdNumber { get; set; }
        public string LoginId { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public bool SalariedFlag { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }

        private Lazy<SelectList> _martialStatusList;
        public SelectList MartialStatusList
        {
            get { return _martialStatusList.Value; }
        }

        private Lazy<SelectList> _genderList;
        public SelectList GenderList
        {
            get { return _genderList.Value; }
        }

        private Lazy<SelectList> _salaryTypeList;
        public SelectList SalaryTypeList
        {
            get { return _salaryTypeList.Value; }
        }

        public EmployeeEditViewModel()
        {
            _martialStatusList = new Lazy<SelectList>(() =>
                {
                    var martialList = new List<KeyValuePair<string, string>>
                        {
                            new KeyValuePair<string, string>("已婚", "M"),
                            new KeyValuePair<string, string>("未婚", "S")
                        };
                    return CreateSelectList(martialList, this.MaritalStatus);
                }, true);

            _genderList = new Lazy<SelectList>(() =>
                {
                    var genderList = new List<KeyValuePair<string, string>>
                        {
                            new KeyValuePair<string, string>("男性", "M"),
                            new KeyValuePair<string, string>("女性", "F")
                        };
                    return CreateSelectList(genderList, this.Gender);
                }, true);

            _salaryTypeList = new Lazy<SelectList>(() =>
                {
                    var salaryType = new List<KeyValuePair<string, bool>>
                        {
                            new KeyValuePair<string, bool>("计时", false),
                            new KeyValuePair<string, bool>("月薪", true)
                        };
                    return CreateSelectList(salaryType, this.SalariedFlag);
                }, true);
        }

        private SelectList CreateSelectList<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs,
                                                  object selectedValue)
        {
            return new SelectList(keyValuePairs, "Value", "Key", selectedValue);
        }
    }
}
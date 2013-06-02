using AdventureWorks.Model;
namespace AdventureWorks.WebUI.MVC.Models
{
    public class EmployeeViewModel
    {
        public int RowNumber { get; set; }
        public int EmployeeId { get; set; }
        public string LoginId { get; set; }
        public string NationalIdNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string BirthDate { get; set; }
        public string MaritalStatus { get; set; }

        public string MartialStatusDisplay
        {
            get { return MaritalStatus == DataDefinition.MartialStatus.Married ? "已婚" : "未婚"; }
        }

        public string Gender { get; set; }

        public string GenderDisplay
        {
            get { return Gender == DataDefinition.Gender.Male ? "男性" : "女性"; }
        }

        public bool SalariedFlag { get; set; }

        public string SalaryDisplay
        {
            get { return SalariedFlag ? "月薪" : "计时"; }
        }

        public string HireDate { get; set; }
    }
}

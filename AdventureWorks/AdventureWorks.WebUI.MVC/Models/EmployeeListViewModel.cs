using System.Collections.Generic;

namespace AdventureWorks.WebUI.MVC.Models
{
    public class EmployeeListViewModel
    {
        public IEnumerable<EmployeeViewModel> Employees { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}

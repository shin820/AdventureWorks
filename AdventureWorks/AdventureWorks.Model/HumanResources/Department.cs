using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.HumanResources
{
    public class Department
    {
        public short DepartmentId { get; set; } // DepartmentID (Primary key)
        public string Name { get; set; } // Name
        public string GroupName { get; set; } // GroupName
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistory { get; set; } // EmployeeDepartmentHistory.FK_EmployeeDepartmentHistory_Department_DepartmentID;

        public Department()
        {
            ModifiedDate = DateTime.Now;
            HumanResources_EmployeeDepartmentHistory = new List<EmployeeDepartmentHistory>();
        }
    }
}
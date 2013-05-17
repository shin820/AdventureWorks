using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.HumanResources
{
    public class HumanResources_Department
    {
        public short DepartmentId { get; set; } // DepartmentID (Primary key)
        public string Name { get; set; } // Name
        public string GroupName { get; set; } // GroupName
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistory { get; set; } // EmployeeDepartmentHistory.FK_EmployeeDepartmentHistory_Department_DepartmentID;

        public HumanResources_Department()
        {
            ModifiedDate = DateTime.Now;
            HumanResources_EmployeeDepartmentHistory = new List<HumanResources_EmployeeDepartmentHistory>();
        }
    }
}
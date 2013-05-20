using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.HumanResources
{
    public class Department : ObjectWithState
    {
        public short DepartmentId { get; set; } // DepartmentID (Primary key)
        public string Name { get; set; } // Name
        public string GroupName { get; set; } // GroupName
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } // EmployeeDepartmentHistory.FK_EmployeeDepartmentHistory_Department_DepartmentID;

        public Department()
        {
            ModifiedDate = DateTime.Now;
            EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
        }
    }
}
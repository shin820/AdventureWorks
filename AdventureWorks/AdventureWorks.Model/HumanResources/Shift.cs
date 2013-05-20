using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.HumanResources
{
    public class Shift : ObjectWithState
    {
        public byte ShiftId { get; set; } // ShiftID (Primary key)
        public string Name { get; set; } // Name
        public DateTime StartTime { get; set; } // StartTime
        public DateTime EndTime { get; set; } // EndTime
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } // EmployeeDepartmentHistory.FK_EmployeeDepartmentHistory_Shift_ShiftID;

        public Shift()
        {
            ModifiedDate = DateTime.Now;
            EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
        }
    }
}
using System;

namespace AdventureWorks.Model.HumanResources
{
    public class HumanResources_EmployeeDepartmentHistory
    {
        public int EmployeeId { get; set; } // EmployeeID (Primary key)
        public short DepartmentId { get; set; } // DepartmentID (Primary key)
        public byte ShiftId { get; set; } // ShiftID (Primary key)
        public DateTime StartDate { get; set; } // StartDate (Primary key)
        public DateTime? EndDate { get; set; } // EndDate
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } //  EmployeeId - FK_EmployeeDepartmentHistory_Employee_EmployeeID
        public virtual HumanResources_Department HumanResources_Department { get; set; } //  DepartmentId - FK_EmployeeDepartmentHistory_Department_DepartmentID
        public virtual HumanResources_Shift HumanResources_Shift { get; set; } //  ShiftId - FK_EmployeeDepartmentHistory_Shift_ShiftID

        public HumanResources_EmployeeDepartmentHistory()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
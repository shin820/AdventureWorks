using System;

namespace AdventureWorks.Model.HumanResources
{
    public class HumanResources_EmployeePayHistory
    {
        public int EmployeeId { get; set; } // EmployeeID (Primary key)
        public DateTime RateChangeDate { get; set; } // RateChangeDate (Primary key)
        public decimal Rate { get; set; } // Rate
        public byte PayFrequency { get; set; } // PayFrequency
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } //  EmployeeId - FK_EmployeePayHistory_Employee_EmployeeID

        public HumanResources_EmployeePayHistory()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
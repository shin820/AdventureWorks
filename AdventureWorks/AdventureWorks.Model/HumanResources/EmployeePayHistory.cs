using System;

namespace AdventureWorks.Model.HumanResources
{
    public class EmployeePayHistory
    {
        public int EmployeeId { get; set; } // EmployeeID (Primary key)
        public DateTime RateChangeDate { get; set; } // RateChangeDate (Primary key)
        public decimal Rate { get; set; } // Rate
        public byte PayFrequency { get; set; } // PayFrequency
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Employee Employee { get; set; } //  EmployeeId - FK_EmployeePayHistory_Employee_EmployeeID

        public EmployeePayHistory()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
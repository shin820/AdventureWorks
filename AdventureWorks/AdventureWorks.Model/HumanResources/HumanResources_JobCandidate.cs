using System;

namespace AdventureWorks.Model.HumanResources
{
    public class HumanResources_JobCandidate
    {
        public int JobCandidateId { get; set; } // JobCandidateID (Primary key)
        public int? EmployeeId { get; set; } // EmployeeID
        public string Resume { get; set; } // Resume
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } //  EmployeeId - FK_JobCandidate_Employee_EmployeeID

        public HumanResources_JobCandidate()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
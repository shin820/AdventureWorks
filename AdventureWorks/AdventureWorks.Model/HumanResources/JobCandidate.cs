using System;

namespace AdventureWorks.Model.HumanResources
{
    public class JobCandidate : ObjectWithState
    {
        public int JobCandidateId { get; set; } // JobCandidateID (Primary key)
        public int? EmployeeId { get; set; } // EmployeeID
        public string Resume { get; set; } // Resume
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Employee Employee { get; set; } //  EmployeeId - FK_JobCandidate_Employee_EmployeeID

        public JobCandidate()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
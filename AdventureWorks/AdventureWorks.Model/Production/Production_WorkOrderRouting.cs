using System;

namespace AdventureWorks.Model.Production
{
    public class Production_WorkOrderRouting
    {
        public int WorkOrderId { get; set; } // WorkOrderID (Primary key)
        public int ProductId { get; set; } // ProductID (Primary key)
        public short OperationSequence { get; set; } // OperationSequence (Primary key)
        public short LocationId { get; set; } // LocationID
        public DateTime ScheduledStartDate { get; set; } // ScheduledStartDate
        public DateTime ScheduledEndDate { get; set; } // ScheduledEndDate
        public DateTime? ActualStartDate { get; set; } // ActualStartDate
        public DateTime? ActualEndDate { get; set; } // ActualEndDate
        public decimal? ActualResourceHrs { get; set; } // ActualResourceHrs
        public decimal PlannedCost { get; set; } // PlannedCost
        public decimal? ActualCost { get; set; } // ActualCost
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_WorkOrder Production_WorkOrder { get; set; } //  WorkOrderId - FK_WorkOrderRouting_WorkOrder_WorkOrderID
        public virtual Production_Location Production_Location { get; set; } //  LocationId - FK_WorkOrderRouting_Location_LocationID

        public Production_WorkOrderRouting()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
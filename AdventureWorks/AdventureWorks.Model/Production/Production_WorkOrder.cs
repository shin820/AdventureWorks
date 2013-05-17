using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Production
{
    public class Production_WorkOrder
    {
        public int WorkOrderId { get; set; } // WorkOrderID (Primary key)
        public int ProductId { get; set; } // ProductID
        public int OrderQty { get; set; } // OrderQty
        public int StockedQty { get; set; } // StockedQty
        public short ScrappedQty { get; set; } // ScrappedQty
        public DateTime StartDate { get; set; } // StartDate
        public DateTime? EndDate { get; set; } // EndDate
        public DateTime DueDate { get; set; } // DueDate
        public short? ScrapReasonId { get; set; } // ScrapReasonID
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_WorkOrderRouting> Production_WorkOrderRouting { get; set; } // WorkOrderRouting.FK_WorkOrderRouting_WorkOrder_WorkOrderID;

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } //  ProductId - FK_WorkOrder_Product_ProductID
        public virtual Production_ScrapReason Production_ScrapReason { get; set; } //  ScrapReasonId - FK_WorkOrder_ScrapReason_ScrapReasonID

        public Production_WorkOrder()
        {
            ModifiedDate = DateTime.Now;
            Production_WorkOrderRouting = new List<Production_WorkOrderRouting>();
        }
    }
}
using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Production
{
    public class Production_ScrapReason
    {
        public short ScrapReasonId { get; set; } // ScrapReasonID (Primary key)
        public string Name { get; set; } // Name
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_WorkOrder> Production_WorkOrder { get; set; } // WorkOrder.FK_WorkOrder_ScrapReason_ScrapReasonID;

        public Production_ScrapReason()
        {
            ModifiedDate = DateTime.Now;
            Production_WorkOrder = new List<Production_WorkOrder>();
        }
    }
}
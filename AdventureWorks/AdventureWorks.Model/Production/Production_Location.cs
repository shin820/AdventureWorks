using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Production
{
    public class Production_Location
    {
        public short LocationId { get; set; } // LocationID (Primary key)
        public string Name { get; set; } // Name
        public decimal CostRate { get; set; } // CostRate
        public decimal Availability { get; set; } // Availability
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_ProductInventory> Production_ProductInventory { get; set; } // ProductInventory.FK_ProductInventory_Location_LocationID;
        public virtual ICollection<Production_WorkOrderRouting> Production_WorkOrderRouting { get; set; } // WorkOrderRouting.FK_WorkOrderRouting_Location_LocationID;

        public Production_Location()
        {
            CostRate = 0.00m;
            Availability = 0.00m;
            ModifiedDate = DateTime.Now;
            Production_ProductInventory = new List<Production_ProductInventory>();
            Production_WorkOrderRouting = new List<Production_WorkOrderRouting>();
        }
    }
}
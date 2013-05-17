using System;

namespace AdventureWorks.Model.Production
{
    public class Production_ProductCostHistory
    {
        public int ProductId { get; set; } // ProductID (Primary key)
        public DateTime StartDate { get; set; } // StartDate (Primary key)
        public DateTime? EndDate { get; set; } // EndDate
        public decimal StandardCost { get; set; } // StandardCost
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } //  ProductId - FK_ProductCostHistory_Product_ProductID

        public Production_ProductCostHistory()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
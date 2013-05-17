using System;

namespace AdventureWorks.Model.Production
{
    public class Production_ProductListPriceHistory
    {
        public int ProductId { get; set; } // ProductID (Primary key)
        public DateTime StartDate { get; set; } // StartDate (Primary key)
        public DateTime? EndDate { get; set; } // EndDate
        public decimal ListPrice { get; set; } // ListPrice
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } //  ProductId - FK_ProductListPriceHistory_Product_ProductID

        public Production_ProductListPriceHistory()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
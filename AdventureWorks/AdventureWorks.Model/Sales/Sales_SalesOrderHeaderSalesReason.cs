using System;

namespace AdventureWorks.Model.Sales
{
    public class Sales_SalesOrderHeaderSalesReason
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key)
        public int SalesReasonId { get; set; } // SalesReasonID (Primary key)
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Sales_SalesOrderHeader Sales_SalesOrderHeader { get; set; } //  SalesOrderId - FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID
        public virtual Sales_SalesReason Sales_SalesReason { get; set; } //  SalesReasonId - FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID

        public Sales_SalesOrderHeaderSalesReason()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
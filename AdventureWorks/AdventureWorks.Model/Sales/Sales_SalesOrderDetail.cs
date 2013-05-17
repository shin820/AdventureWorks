using System;

namespace AdventureWorks.Model.Sales
{
    public class Sales_SalesOrderDetail
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key)
        public int SalesOrderDetailId { get; set; } // SalesOrderDetailID (Primary key)
        public string CarrierTrackingNumber { get; set; } // CarrierTrackingNumber
        public short OrderQty { get; set; } // OrderQty
        public int ProductId { get; set; } // ProductID
        public int SpecialOfferId { get; set; } // SpecialOfferID
        public decimal UnitPrice { get; set; } // UnitPrice
        public decimal UnitPriceDiscount { get; set; } // UnitPriceDiscount
        public decimal LineTotal { get; set; } // LineTotal
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Sales_SalesOrderHeader Sales_SalesOrderHeader { get; set; } //  SalesOrderId - FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID

        public Sales_SalesOrderDetail()
        {
            UnitPriceDiscount = 0.0m;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}
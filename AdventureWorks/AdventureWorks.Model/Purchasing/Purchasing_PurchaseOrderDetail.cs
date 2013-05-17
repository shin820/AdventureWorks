using System;
using AdventureWorks.Model.Production;

namespace AdventureWorks.Model.Purchasing
{
    public class Purchasing_PurchaseOrderDetail
    {
        public int PurchaseOrderId { get; set; } // PurchaseOrderID (Primary key)
        public int PurchaseOrderDetailId { get; set; } // PurchaseOrderDetailID (Primary key)
        public DateTime DueDate { get; set; } // DueDate
        public short OrderQty { get; set; } // OrderQty
        public int ProductId { get; set; } // ProductID
        public decimal UnitPrice { get; set; } // UnitPrice
        public decimal LineTotal { get; set; } // LineTotal
        public decimal ReceivedQty { get; set; } // ReceivedQty
        public decimal RejectedQty { get; set; } // RejectedQty
        public decimal StockedQty { get; set; } // StockedQty
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Purchasing_PurchaseOrderHeader Purchasing_PurchaseOrderHeader { get; set; } //  PurchaseOrderId - FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID
        public virtual Production_Product Production_Product { get; set; } //  ProductId - FK_PurchaseOrderDetail_Product_ProductID

        public Purchasing_PurchaseOrderDetail()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
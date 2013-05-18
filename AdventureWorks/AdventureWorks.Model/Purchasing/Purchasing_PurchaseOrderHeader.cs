using System;
using System.Collections.Generic;
using AdventureWorks.Model.HumanResources;

namespace AdventureWorks.Model.Purchasing
{
    public class Purchasing_PurchaseOrderHeader
    {
        public int PurchaseOrderId { get; set; } // PurchaseOrderID (Primary key)
        public byte RevisionNumber { get; set; } // RevisionNumber
        public byte Status { get; set; } // Status
        public int EmployeeId { get; set; } // EmployeeID
        public int VendorId { get; set; } // VendorID
        public int ShipMethodId { get; set; } // ShipMethodID
        public DateTime OrderDate { get; set; } // OrderDate
        public DateTime? ShipDate { get; set; } // ShipDate
        public decimal SubTotal { get; set; } // SubTotal
        public decimal TaxAmt { get; set; } // TaxAmt
        public decimal Freight { get; set; } // Freight
        public decimal TotalDue { get; set; } // TotalDue
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetail { get; set; } // PurchaseOrderDetail.FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID;

        // Foreign keys
        public virtual Employee Employee { get; set; } //  EmployeeId - FK_PurchaseOrderHeader_Employee_EmployeeID
        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; } //  VendorId - FK_PurchaseOrderHeader_Vendor_VendorID
        public virtual Purchasing_ShipMethod Purchasing_ShipMethod { get; set; } //  ShipMethodId - FK_PurchaseOrderHeader_ShipMethod_ShipMethodID

        public Purchasing_PurchaseOrderHeader()
        {
            RevisionNumber = 0;
            Status = 1;
            OrderDate = DateTime.Now;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            ModifiedDate = DateTime.Now;
            Purchasing_PurchaseOrderDetail = new List<Purchasing_PurchaseOrderDetail>();
        }
    }
}
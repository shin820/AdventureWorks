using System;
using AdventureWorks.Model.Production;

namespace AdventureWorks.Model.Purchasing
{
    public class Purchasing_ProductVendor
    {
        public int ProductId { get; set; } // ProductID (Primary key)
        public int VendorId { get; set; } // VendorID (Primary key)
        public int AverageLeadTime { get; set; } // AverageLeadTime
        public decimal StandardPrice { get; set; } // StandardPrice
        public decimal? LastReceiptCost { get; set; } // LastReceiptCost
        public DateTime? LastReceiptDate { get; set; } // LastReceiptDate
        public int MinOrderQty { get; set; } // MinOrderQty
        public int MaxOrderQty { get; set; } // MaxOrderQty
        public int? OnOrderQty { get; set; } // OnOrderQty
        public string UnitMeasureCode { get; set; } // UnitMeasureCode
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } //  ProductId - FK_ProductVendor_Product_ProductID
        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; } //  VendorId - FK_ProductVendor_Vendor_VendorID
        public virtual Production_UnitMeasure Production_UnitMeasure { get; set; } //  UnitMeasureCode - FK_ProductVendor_UnitMeasure_UnitMeasureCode

        public Purchasing_ProductVendor()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
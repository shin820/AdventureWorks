using System;

namespace AdventureWorks.Model.Production
{
    public class Production_ProductInventory
    {
        public int ProductId { get; set; } // ProductID (Primary key)
        public short LocationId { get; set; } // LocationID (Primary key)
        public string Shelf { get; set; } // Shelf
        public byte Bin { get; set; } // Bin
        public short Quantity { get; set; } // Quantity
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } //  ProductId - FK_ProductInventory_Product_ProductID
        public virtual Production_Location Production_Location { get; set; } //  LocationId - FK_ProductInventory_Location_LocationID

        public Production_ProductInventory()
        {
            Quantity = 0;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}
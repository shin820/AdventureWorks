using System;
using System.Collections.Generic;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.Model.Purchasing
{
    public class Purchasing_ShipMethod
    {
        public int ShipMethodId { get; set; } // ShipMethodID (Primary key)
        public string Name { get; set; } // Name
        public decimal ShipBase { get; set; } // ShipBase
        public decimal ShipRate { get; set; } // ShipRate
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_ShipMethod_ShipMethodID;
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_ShipMethod_ShipMethodID;

        public Purchasing_ShipMethod()
        {
            ShipBase = 0.00m;
            ShipRate = 0.00m;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Purchasing_PurchaseOrderHeader = new List<Purchasing_PurchaseOrderHeader>();
            Sales_SalesOrderHeader = new List<Sales_SalesOrderHeader>();
        }
    }
}
using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Sales
{
    public class Sales_Customer
    {
        public int CustomerId { get; set; } // CustomerID (Primary key)
        public int? TerritoryId { get; set; } // TerritoryID
        public string AccountNumber { get; set; } // AccountNumber
        public string CustomerType { get; set; } // CustomerType
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_CustomerAddress> Sales_CustomerAddress { get; set; } // CustomerAddress.FK_CustomerAddress_Customer_CustomerID;
        public virtual Sales_Individual Sales_Individual { get; set; } // Individual.FK_Individual_Customer_CustomerID;
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Customer_CustomerID;
        public virtual Sales_Store Sales_Store { get; set; } // Store.FK_Store_Customer_CustomerID;

        // Foreign keys
        public virtual SalesTerritory Sales_SalesTerritory { get; set; } //  TerritoryId - FK_Customer_SalesTerritory_TerritoryID

        public Sales_Customer()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_CustomerAddress = new List<Sales_CustomerAddress>();
            Sales_SalesOrderHeader = new List<Sales_SalesOrderHeader>();
        }
    }
}
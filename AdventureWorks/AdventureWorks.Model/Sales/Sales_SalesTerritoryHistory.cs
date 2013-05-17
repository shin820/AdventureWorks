using System;

namespace AdventureWorks.Model.Sales
{
    public class Sales_SalesTerritoryHistory
    {
        public int SalesPersonId { get; set; } // SalesPersonID (Primary key)
        public int TerritoryId { get; set; } // TerritoryID (Primary key)
        public DateTime StartDate { get; set; } // StartDate (Primary key)
        public DateTime? EndDate { get; set; } // EndDate
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } //  SalesPersonId - FK_SalesTerritoryHistory_SalesPerson_SalesPersonID
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } //  TerritoryId - FK_SalesTerritoryHistory_SalesTerritory_TerritoryID

        public Sales_SalesTerritoryHistory()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}
using System;
using System.Collections.Generic;
using AdventureWorks.Model.HumanResources;

namespace AdventureWorks.Model.Sales
{
    public class Sales_SalesPerson
    {
        public int SalesPersonId { get; set; } // SalesPersonID (Primary key)
        public int? TerritoryId { get; set; } // TerritoryID
        public decimal? SalesQuota { get; set; } // SalesQuota
        public decimal Bonus { get; set; } // Bonus
        public decimal CommissionPct { get; set; } // CommissionPct
        public decimal SalesYtd { get; set; } // SalesYTD
        public decimal SalesLastYear { get; set; } // SalesLastYear
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesPerson_SalesPersonID;
        public virtual ICollection<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistory { get; set; } // SalesPersonQuotaHistory.FK_SalesPersonQuotaHistory_SalesPerson_SalesPersonID;
        public virtual ICollection<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistory { get; set; } // SalesTerritoryHistory.FK_SalesTerritoryHistory_SalesPerson_SalesPersonID;
        public virtual ICollection<Sales_Store> Sales_Store { get; set; } // Store.FK_Store_SalesPerson_SalesPersonID;

        // Foreign keys
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } //  SalesPersonId - FK_SalesPerson_Employee_SalesPersonID
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } //  TerritoryId - FK_SalesPerson_SalesTerritory_TerritoryID

        public Sales_SalesPerson()
        {
            Bonus = 0.00m;
            CommissionPct = 0.00m;
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_SalesOrderHeader = new List<Sales_SalesOrderHeader>();
            Sales_SalesPersonQuotaHistory = new List<Sales_SalesPersonQuotaHistory>();
            Sales_SalesTerritoryHistory = new List<Sales_SalesTerritoryHistory>();
            Sales_Store = new List<Sales_Store>();
        }
    }
}
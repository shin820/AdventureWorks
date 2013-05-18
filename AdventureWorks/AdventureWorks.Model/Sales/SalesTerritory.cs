using System;
using System.Collections.Generic;
using AdventureWorks.Model.Person;

namespace AdventureWorks.Model.Sales
{
    public class SalesTerritory : ObjectWithState
    {
        public int TerritoryId { get; set; } // TerritoryID (Primary key)
        public string Name { get; set; } // Name
        public string CountryRegionCode { get; set; } // CountryRegionCode
        public string Group { get; set; } // Group
        public decimal SalesYtd { get; set; } // SalesYTD
        public decimal SalesLastYear { get; set; } // SalesLastYear
        public decimal CostYtd { get; set; } // CostYTD
        public decimal CostLastYear { get; set; } // CostLastYear
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_Customer> Sales_Customer { get; set; } // Customer.FK_Customer_SalesTerritory_TerritoryID;
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesTerritory_TerritoryID;
        public virtual ICollection<Sales_SalesPerson> Sales_SalesPerson { get; set; } // SalesPerson.FK_SalesPerson_SalesTerritory_TerritoryID;
        public virtual ICollection<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistory { get; set; } // SalesTerritoryHistory.FK_SalesTerritoryHistory_SalesTerritory_TerritoryID;
        public virtual ICollection<StateProvince> Person_StateProvince { get; set; } // StateProvince.FK_StateProvince_SalesTerritory_TerritoryID;

        public SalesTerritory()
        {
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            CostYtd = 0.00m;
            CostLastYear = 0.00m;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_Customer = new List<Sales_Customer>();
            Sales_SalesOrderHeader = new List<Sales_SalesOrderHeader>();
            Sales_SalesPerson = new List<Sales_SalesPerson>();
            Sales_SalesTerritoryHistory = new List<Sales_SalesTerritoryHistory>();
            Person_StateProvince = new List<StateProvince>();
        }
    }
}
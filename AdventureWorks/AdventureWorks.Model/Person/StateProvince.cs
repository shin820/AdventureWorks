using System;
using System.Collections.Generic;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.Model.Person
{
    public class StateProvince : ObjectWithState
    {
        public int StateProvinceId { get; set; } // StateProvinceID (Primary key)
        public string StateProvinceCode { get; set; } // StateProvinceCode
        public string CountryRegionCode { get; set; } // CountryRegionCode
        public bool IsOnlyStateProvinceFlag { get; set; } // IsOnlyStateProvinceFlag
        public string Name { get; set; } // Name
        public int TerritoryId { get; set; } // TerritoryID
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public ICollection<Address> PersonAddresses { get; set; } // Address.FK_Address_StateProvince_StateProvinceID;
        public ICollection<Sales_SalesTaxRate> SalesTaxRates { get; set; } // SalesTaxRate.FK_SalesTaxRate_StateProvince_StateProvinceID;

        // Foreign keys
        public virtual CountryRegion CountryRegion { get; set; } //  CountryRegionCode - FK_StateProvince_CountryRegion_CountryRegionCode
        public virtual SalesTerritory SalesTerritory { get; set; } //  TerritoryId - FK_StateProvince_SalesTerritory_TerritoryID

        public StateProvince()
        {
            IsOnlyStateProvinceFlag = true;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            PersonAddresses = new List<Address>();
            SalesTaxRates = new List<Sales_SalesTaxRate>();
        }
    }
}
using System;
using System.Collections.Generic;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.Model.Person
{
    public class Person_StateProvince
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
        public virtual ICollection<Person_Address> Person_Address { get; set; } // Address.FK_Address_StateProvince_StateProvinceID;
        public virtual ICollection<Sales_SalesTaxRate> Sales_SalesTaxRate { get; set; } // SalesTaxRate.FK_SalesTaxRate_StateProvince_StateProvinceID;

        // Foreign keys
        public virtual Person_CountryRegion Person_CountryRegion { get; set; } //  CountryRegionCode - FK_StateProvince_CountryRegion_CountryRegionCode
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } //  TerritoryId - FK_StateProvince_SalesTerritory_TerritoryID

        public Person_StateProvince()
        {
            IsOnlyStateProvinceFlag = true;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Person_Address = new List<Person_Address>();
            Sales_SalesTaxRate = new List<Sales_SalesTaxRate>();
        }
    }
}
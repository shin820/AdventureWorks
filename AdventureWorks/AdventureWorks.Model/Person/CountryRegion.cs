using System;
using System.Collections.Generic;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.Model.Person
{
    public class CountryRegion : ObjectWithState
    {
        public string CountryRegionCode { get; set; } // CountryRegionCode (Primary key)
        public string Name { get; set; } // Name
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_CountryRegionCurrency> Sales_CountryRegionCurrency { get; set; } // CountryRegionCurrency.FK_CountryRegionCurrency_CountryRegion_CountryRegionCode;
        public virtual ICollection<StateProvince> Person_StateProvince { get; set; } // StateProvince.FK_StateProvince_CountryRegion_CountryRegionCode;

        public CountryRegion()
        {
            ModifiedDate = DateTime.Now;
            Sales_CountryRegionCurrency = new List<Sales_CountryRegionCurrency>();
            Person_StateProvince = new List<StateProvince>();
        }
    }
}
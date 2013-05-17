using System;
using AdventureWorks.Model.Person;

namespace AdventureWorks.Model.Sales
{
    public class Sales_CountryRegionCurrency
    {
        public string CountryRegionCode { get; set; } // CountryRegionCode (Primary key)
        public string CurrencyCode { get; set; } // CurrencyCode (Primary key)
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Person_CountryRegion Person_CountryRegion { get; set; } //  CountryRegionCode - FK_CountryRegionCurrency_CountryRegion_CountryRegionCode
        public virtual Sales_Currency Sales_Currency { get; set; } //  CurrencyCode - FK_CountryRegionCurrency_Currency_CurrencyCode

        public Sales_CountryRegionCurrency()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
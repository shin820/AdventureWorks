using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Sales
{
    public class Sales_Currency
    {
        public string CurrencyCode { get; set; } // CurrencyCode (Primary key)
        public string Name { get; set; } // Name
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_CountryRegionCurrency> Sales_CountryRegionCurrency { get; set; } // CountryRegionCurrency.FK_CountryRegionCurrency_Currency_CurrencyCode;
        public virtual ICollection<Sales_CurrencyRate> Sales_CurrencyRate { get; set; } // CurrencyRate.FK_CurrencyRate_Currency_FromCurrencyCode;
        public virtual ICollection<Sales_CurrencyRate> Sales_CurrencyRate1 { get; set; } // CurrencyRate.FK_CurrencyRate_Currency_ToCurrencyCode;

        public Sales_Currency()
        {
            ModifiedDate = DateTime.Now;
            Sales_CountryRegionCurrency = new List<Sales_CountryRegionCurrency>();
            Sales_CurrencyRate = new List<Sales_CurrencyRate>();
            Sales_CurrencyRate1 = new List<Sales_CurrencyRate>();
        }
    }
}
using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Sales
{
    public class Sales_CurrencyRate
    {
        public int CurrencyRateId { get; set; } // CurrencyRateID (Primary key)
        public DateTime CurrencyRateDate { get; set; } // CurrencyRateDate
        public string FromCurrencyCode { get; set; } // FromCurrencyCode
        public string ToCurrencyCode { get; set; } // ToCurrencyCode
        public decimal AverageRate { get; set; } // AverageRate
        public decimal EndOfDayRate { get; set; } // EndOfDayRate
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_CurrencyRate_CurrencyRateID;

        // Foreign keys
        public virtual Sales_Currency Sales_Currency { get; set; } //  FromCurrencyCode - FK_CurrencyRate_Currency_FromCurrencyCode
        public virtual Sales_Currency Sales_Currency1 { get; set; } //  ToCurrencyCode - FK_CurrencyRate_Currency_ToCurrencyCode

        public Sales_CurrencyRate()
        {
            ModifiedDate = DateTime.Now;
            Sales_SalesOrderHeader = new List<Sales_SalesOrderHeader>();
        }
    }
}
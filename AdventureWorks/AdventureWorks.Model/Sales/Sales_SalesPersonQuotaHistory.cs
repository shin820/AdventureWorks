using System;

namespace AdventureWorks.Model.Sales
{
    public class Sales_SalesPersonQuotaHistory
    {
        public int SalesPersonId { get; set; } // SalesPersonID (Primary key)
        public DateTime QuotaDate { get; set; } // QuotaDate (Primary key)
        public decimal SalesQuota { get; set; } // SalesQuota
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } //  SalesPersonId - FK_SalesPersonQuotaHistory_SalesPerson_SalesPersonID

        public Sales_SalesPersonQuotaHistory()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}
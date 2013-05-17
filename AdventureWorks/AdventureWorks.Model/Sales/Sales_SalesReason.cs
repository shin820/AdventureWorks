using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Sales
{
    public class Sales_SalesReason
    {
        public int SalesReasonId { get; set; } // SalesReasonID (Primary key)
        public string Name { get; set; } // Name
        public string ReasonType { get; set; } // ReasonType
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReason { get; set; } // SalesOrderHeaderSalesReason.FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID;

        public Sales_SalesReason()
        {
            ModifiedDate = DateTime.Now;
            Sales_SalesOrderHeaderSalesReason = new List<Sales_SalesOrderHeaderSalesReason>();
        }
    }
}
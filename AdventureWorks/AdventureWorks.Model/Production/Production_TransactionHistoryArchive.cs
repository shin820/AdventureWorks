using System;

namespace AdventureWorks.Model.Production
{
    public class Production_TransactionHistoryArchive
    {
        public int TransactionId { get; set; } // TransactionID (Primary key)
        public int ProductId { get; set; } // ProductID
        public int ReferenceOrderId { get; set; } // ReferenceOrderID
        public int ReferenceOrderLineId { get; set; } // ReferenceOrderLineID
        public DateTime TransactionDate { get; set; } // TransactionDate
        public string TransactionType { get; set; } // TransactionType
        public int Quantity { get; set; } // Quantity
        public decimal ActualCost { get; set; } // ActualCost
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        public Production_TransactionHistoryArchive()
        {
            ReferenceOrderLineId = 0;
            TransactionDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }
}
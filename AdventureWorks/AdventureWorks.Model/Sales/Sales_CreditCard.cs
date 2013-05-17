using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Sales
{
    public class Sales_CreditCard
    {
        public int CreditCardId { get; set; } // CreditCardID (Primary key)
        public string CardType { get; set; } // CardType
        public string CardNumber { get; set; } // CardNumber
        public byte ExpMonth { get; set; } // ExpMonth
        public short ExpYear { get; set; } // ExpYear
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_ContactCreditCard> Sales_ContactCreditCard { get; set; } // ContactCreditCard.FK_ContactCreditCard_CreditCard_CreditCardID;
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_CreditCard_CreditCardID;

        public Sales_CreditCard()
        {
            ModifiedDate = DateTime.Now;
            Sales_ContactCreditCard = new List<Sales_ContactCreditCard>();
            Sales_SalesOrderHeader = new List<Sales_SalesOrderHeader>();
        }
    }
}
using System;
using AdventureWorks.Model.Person;

namespace AdventureWorks.Model.Sales
{
    public class Sales_ContactCreditCard
    {
        public int ContactId { get; set; } // ContactID (Primary key)
        public int CreditCardId { get; set; } // CreditCardID (Primary key)
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Person_Contact Person_Contact { get; set; } //  ContactId - FK_ContactCreditCard_Contact_ContactID
        public virtual Sales_CreditCard Sales_CreditCard { get; set; } //  CreditCardId - FK_ContactCreditCard_CreditCard_CreditCardID

        public Sales_ContactCreditCard()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
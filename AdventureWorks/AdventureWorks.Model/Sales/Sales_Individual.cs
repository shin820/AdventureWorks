using System;
using AdventureWorks.Model.Person;

namespace AdventureWorks.Model.Sales
{
    public class Sales_Individual
    {
        public int CustomerId { get; set; } // CustomerID (Primary key)
        public int ContactId { get; set; } // ContactID
        public string Demographics { get; set; } // Demographics
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Sales_Customer Sales_Customer { get; set; } //  CustomerId - FK_Individual_Customer_CustomerID
        public virtual Person_Contact Person_Contact { get; set; } //  ContactId - FK_Individual_Contact_ContactID

        public Sales_Individual()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
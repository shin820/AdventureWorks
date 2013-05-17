using System;
using AdventureWorks.Model.Person;

namespace AdventureWorks.Model.Sales
{
    public class Sales_StoreContact
    {
        public int CustomerId { get; set; } // CustomerID (Primary key)
        public int ContactId { get; set; } // ContactID (Primary key)
        public int ContactTypeId { get; set; } // ContactTypeID
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Sales_Store Sales_Store { get; set; } //  CustomerId - FK_StoreContact_Store_CustomerID
        public virtual Person_Contact Person_Contact { get; set; } //  ContactId - FK_StoreContact_Contact_ContactID
        public virtual Person_ContactType Person_ContactType { get; set; } //  ContactTypeId - FK_StoreContact_ContactType_ContactTypeID

        public Sales_StoreContact()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}
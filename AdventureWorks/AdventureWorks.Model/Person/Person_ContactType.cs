using System;
using System.Collections.Generic;
using AdventureWorks.Model.Purchasing;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.Model.Person
{
    public class Person_ContactType
    {
        public int ContactTypeId { get; set; } // ContactTypeID (Primary key)
        public string Name { get; set; } // Name
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_StoreContact> Sales_StoreContact { get; set; } // StoreContact.FK_StoreContact_ContactType_ContactTypeID;
        public virtual ICollection<Purchasing_VendorContact> Purchasing_VendorContact { get; set; } // VendorContact.FK_VendorContact_ContactType_ContactTypeID;

        public Person_ContactType()
        {
            ModifiedDate = DateTime.Now;
            Sales_StoreContact = new List<Sales_StoreContact>();
            Purchasing_VendorContact = new List<Purchasing_VendorContact>();
        }
    }
}
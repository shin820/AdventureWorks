using System;
using AdventureWorks.Model.Person;

namespace AdventureWorks.Model.Purchasing
{
    public class Purchasing_VendorContact
    {
        public int VendorId { get; set; } // VendorID (Primary key)
        public int ContactId { get; set; } // ContactID (Primary key)
        public int ContactTypeId { get; set; } // ContactTypeID
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; } //  VendorId - FK_VendorContact_Vendor_VendorID
        public virtual Person_Contact Person_Contact { get; set; } //  ContactId - FK_VendorContact_Contact_ContactID
        public virtual Person_ContactType Person_ContactType { get; set; } //  ContactTypeId - FK_VendorContact_ContactType_ContactTypeID

        public Purchasing_VendorContact()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
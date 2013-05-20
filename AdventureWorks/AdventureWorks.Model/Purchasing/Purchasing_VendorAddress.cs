using System;
using AdventureWorks.Model.Person;

namespace AdventureWorks.Model.Purchasing
{
    public class Purchasing_VendorAddress
    {
        public int VendorId { get; set; } // VendorID (Primary key)
        public int AddressId { get; set; } // AddressID (Primary key)
        public int AddressTypeId { get; set; } // AddressTypeID
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; } //  VendorId - FK_VendorAddress_Vendor_VendorID
        public virtual PersonAddress Person_Address { get; set; } //  AddressId - FK_VendorAddress_Address_AddressID
        public virtual Person_AddressType Person_AddressType { get; set; } //  AddressTypeId - FK_VendorAddress_AddressType_AddressTypeID

        public Purchasing_VendorAddress()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
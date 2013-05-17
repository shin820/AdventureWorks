using System;
using System.Collections.Generic;
using AdventureWorks.Model.Purchasing;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.Model.Person
{
    public class Person_AddressType
    {
        public int AddressTypeId { get; set; } // AddressTypeID (Primary key)
        public string Name { get; set; } // Name
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_CustomerAddress> Sales_CustomerAddress { get; set; } // CustomerAddress.FK_CustomerAddress_AddressType_AddressTypeID;
        public virtual ICollection<Purchasing_VendorAddress> Purchasing_VendorAddress { get; set; } // VendorAddress.FK_VendorAddress_AddressType_AddressTypeID;

        public Person_AddressType()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_CustomerAddress = new List<Sales_CustomerAddress>();
            Purchasing_VendorAddress = new List<Purchasing_VendorAddress>();
        }
    }
}
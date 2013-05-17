using System;
using AdventureWorks.Model.Person;

namespace AdventureWorks.Model.Sales
{
    public class Sales_CustomerAddress
    {
        public int CustomerId { get; set; } // CustomerID (Primary key)
        public int AddressId { get; set; } // AddressID (Primary key)
        public int AddressTypeId { get; set; } // AddressTypeID
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Sales_Customer Sales_Customer { get; set; } //  CustomerId - FK_CustomerAddress_Customer_CustomerID
        public virtual Person_Address Person_Address { get; set; } //  AddressId - FK_CustomerAddress_Address_AddressID
        public virtual Person_AddressType Person_AddressType { get; set; } //  AddressTypeId - FK_CustomerAddress_AddressType_AddressTypeID

        public Sales_CustomerAddress()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}
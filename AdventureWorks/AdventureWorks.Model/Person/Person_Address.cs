using System;
using System.Collections.Generic;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.Model.Purchasing;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.Model.Person
{
    public class Person_Address
    {
        public int AddressId { get; set; } // AddressID (Primary key)
        public string AddressLine1 { get; set; } // AddressLine1
        public string AddressLine2 { get; set; } // AddressLine2
        public string City { get; set; } // City
        public int StateProvinceId { get; set; } // StateProvinceID
        public string PostalCode { get; set; } // PostalCode
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_CustomerAddress> Sales_CustomerAddress { get; set; } // CustomerAddress.FK_CustomerAddress_Address_AddressID;
        public virtual ICollection<HumanResources_EmployeeAddress> HumanResources_EmployeeAddress { get; set; } // EmployeeAddress.FK_EmployeeAddress_Address_AddressID;
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_BillToAddressID;
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader1 { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_ShipToAddressID;
        public virtual ICollection<Purchasing_VendorAddress> Purchasing_VendorAddress { get; set; } // VendorAddress.FK_VendorAddress_Address_AddressID;

        // Foreign keys
        public virtual Person_StateProvince Person_StateProvince { get; set; } //  StateProvinceId - FK_Address_StateProvince_StateProvinceID

        public Person_Address()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_CustomerAddress = new List<Sales_CustomerAddress>();
            HumanResources_EmployeeAddress = new List<HumanResources_EmployeeAddress>();
            Sales_SalesOrderHeader = new List<Sales_SalesOrderHeader>();
            Sales_SalesOrderHeader1 = new List<Sales_SalesOrderHeader>();
            Purchasing_VendorAddress = new List<Purchasing_VendorAddress>();
        }
    }
}
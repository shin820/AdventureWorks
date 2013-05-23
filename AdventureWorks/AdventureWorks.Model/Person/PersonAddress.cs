using System;
using System.Collections.Generic;
using AdventureWorks.Model.HumanResources;
using AdventureWorks.Model.Purchasing;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.Model.Person
{
    public class Address
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
        public ICollection<Sales_CustomerAddress> CustomerAddresses { get; set; } // CustomerAddress.FK_CustomerAddress_Address_AddressID;
        public ICollection<Sales_SalesOrderHeader> BillToSalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_BillToAddressID;
        public ICollection<Sales_SalesOrderHeader> ShipToSalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_ShipToAddressID;
        public ICollection<Purchasing_VendorAddress> VendorAddresses { get; set; } // VendorAddress.FK_VendorAddress_Address_AddressID;

        ////many to many by HumanResources.EmployeeAddress
        public ICollection<Employee> Employees { get; set; }

        // Foreign keys
        public virtual StateProvince StateProvince { get; set; } //  StateProvinceId - FK_Address_StateProvince_StateProvinceID

        public Address()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            CustomerAddresses = new List<Sales_CustomerAddress>();
            //EmployeeAddresses = new List<EmployeeAddress>();
            BillToSalesOrderHeaders = new List<Sales_SalesOrderHeader>();
            ShipToSalesOrderHeaders = new List<Sales_SalesOrderHeader>();
            VendorAddresses = new List<Purchasing_VendorAddress>();

            Employees = new List<Employee>();
        }
    }
}
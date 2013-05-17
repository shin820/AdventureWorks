using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Sales
{
    public class Sales_Store
    {
        public int CustomerId { get; set; } // CustomerID (Primary key)
        public string Name { get; set; } // Name
        public int? SalesPersonId { get; set; } // SalesPersonID
        public string Demographics { get; set; } // Demographics
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_StoreContact> Sales_StoreContact { get; set; } // StoreContact.FK_StoreContact_Store_CustomerID;

        // Foreign keys
        public virtual Sales_Customer Sales_Customer { get; set; } //  CustomerId - FK_Store_Customer_CustomerID
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } //  SalesPersonId - FK_Store_SalesPerson_SalesPersonID

        public Sales_Store()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_StoreContact = new List<Sales_StoreContact>();
        }
    }
}
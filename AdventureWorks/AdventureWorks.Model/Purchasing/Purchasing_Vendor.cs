using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Purchasing
{
    public class Purchasing_Vendor
    {
        public int VendorId { get; set; } // VendorID (Primary key)
        public string AccountNumber { get; set; } // AccountNumber
        public string Name { get; set; } // Name
        public byte CreditRating { get; set; } // CreditRating
        public bool PreferredVendorStatus { get; set; } // PreferredVendorStatus
        public bool ActiveFlag { get; set; } // ActiveFlag
        public string PurchasingWebServiceUrl { get; set; } // PurchasingWebServiceURL
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Purchasing_ProductVendor> Purchasing_ProductVendor { get; set; } // ProductVendor.FK_ProductVendor_Vendor_VendorID;
        public virtual ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_Vendor_VendorID;
        public virtual ICollection<Purchasing_VendorAddress> Purchasing_VendorAddress { get; set; } // VendorAddress.FK_VendorAddress_Vendor_VendorID;
        public virtual ICollection<Purchasing_VendorContact> Purchasing_VendorContact { get; set; } // VendorContact.FK_VendorContact_Vendor_VendorID;

        public Purchasing_Vendor()
        {
            PreferredVendorStatus = true;
            ActiveFlag = true;
            ModifiedDate = DateTime.Now;
            Purchasing_ProductVendor = new List<Purchasing_ProductVendor>();
            Purchasing_PurchaseOrderHeader = new List<Purchasing_PurchaseOrderHeader>();
            Purchasing_VendorAddress = new List<Purchasing_VendorAddress>();
            Purchasing_VendorContact = new List<Purchasing_VendorContact>();
        }
    }
}
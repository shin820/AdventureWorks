using System;
using System.Collections.Generic;
using AdventureWorks.Model.Person;
using AdventureWorks.Model.Purchasing;

namespace AdventureWorks.Model.Sales
{
    public class Sales_SalesOrderHeader
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key)
        public byte RevisionNumber { get; set; } // RevisionNumber
        public DateTime OrderDate { get; set; } // OrderDate
        public DateTime DueDate { get; set; } // DueDate
        public DateTime? ShipDate { get; set; } // ShipDate
        public byte Status { get; set; } // Status
        public bool OnlineOrderFlag { get; set; } // OnlineOrderFlag
        public string SalesOrderNumber { get; set; } // SalesOrderNumber
        public string PurchaseOrderNumber { get; set; } // PurchaseOrderNumber
        public string AccountNumber { get; set; } // AccountNumber
        public int CustomerId { get; set; } // CustomerID
        public int ContactId { get; set; } // ContactID
        public int? SalesPersonId { get; set; } // SalesPersonID
        public int? TerritoryId { get; set; } // TerritoryID
        public int BillToAddressId { get; set; } // BillToAddressID
        public int ShipToAddressId { get; set; } // ShipToAddressID
        public int ShipMethodId { get; set; } // ShipMethodID
        public int? CreditCardId { get; set; } // CreditCardID
        public string CreditCardApprovalCode { get; set; } // CreditCardApprovalCode
        public int? CurrencyRateId { get; set; } // CurrencyRateID
        public decimal SubTotal { get; set; } // SubTotal
        public decimal TaxAmt { get; set; } // TaxAmt
        public decimal Freight { get; set; } // Freight
        public decimal TotalDue { get; set; } // TotalDue
        public string Comment { get; set; } // Comment
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_SalesOrderDetail> Sales_SalesOrderDetail { get; set; } // SalesOrderDetail.FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID;
        public virtual ICollection<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReason { get; set; } // SalesOrderHeaderSalesReason.FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID;

        // Foreign keys
        public virtual Sales_Customer Sales_Customer { get; set; } //  CustomerId - FK_SalesOrderHeader_Customer_CustomerID
        public virtual Person_Contact Person_Contact { get; set; } //  ContactId - FK_SalesOrderHeader_Contact_ContactID
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } //  SalesPersonId - FK_SalesOrderHeader_SalesPerson_SalesPersonID
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } //  TerritoryId - FK_SalesOrderHeader_SalesTerritory_TerritoryID
        public virtual Person_Address Person_Address { get; set; } //  BillToAddressId - FK_SalesOrderHeader_Address_BillToAddressID
        public virtual Person_Address Person_Address1 { get; set; } //  ShipToAddressId - FK_SalesOrderHeader_Address_ShipToAddressID
        public virtual Purchasing_ShipMethod Purchasing_ShipMethod { get; set; } //  ShipMethodId - FK_SalesOrderHeader_ShipMethod_ShipMethodID
        public virtual Sales_CreditCard Sales_CreditCard { get; set; } //  CreditCardId - FK_SalesOrderHeader_CreditCard_CreditCardID
        public virtual Sales_CurrencyRate Sales_CurrencyRate { get; set; } //  CurrencyRateId - FK_SalesOrderHeader_CurrencyRate_CurrencyRateID

        public Sales_SalesOrderHeader()
        {
            RevisionNumber = 0;
            OrderDate = DateTime.Now;
            Status = 1;
            OnlineOrderFlag = true;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_SalesOrderDetail = new List<Sales_SalesOrderDetail>();
            Sales_SalesOrderHeaderSalesReason = new List<Sales_SalesOrderHeaderSalesReason>();
        }
    }
}
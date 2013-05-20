using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.DataAccess.Configurations.Sales
{
    internal class Sales_SalesOrderHeaderConfiguration : EntityTypeConfiguration<Sales_SalesOrderHeader>
    {
        public Sales_SalesOrderHeaderConfiguration()
        {
            ToTable("Sales.SalesOrderHeader");
            HasKey(x => x.SalesOrderId);

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName("RevisionNumber").IsRequired();
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsRequired();
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.ShipDate).HasColumnName("ShipDate").IsOptional();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.OnlineOrderFlag).HasColumnName("OnlineOrderFlag").IsRequired();
            Property(x => x.SalesOrderNumber).HasColumnName("SalesOrderNumber").IsRequired().HasMaxLength(25);
            Property(x => x.PurchaseOrderNumber).HasColumnName("PurchaseOrderNumber").IsOptional().HasMaxLength(25);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsOptional().HasMaxLength(15);
            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired();
            Property(x => x.ContactId).HasColumnName("ContactID").IsRequired();
            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsOptional();
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.BillToAddressId).HasColumnName("BillToAddressID").IsRequired();
            Property(x => x.ShipToAddressId).HasColumnName("ShipToAddressID").IsRequired();
            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired();
            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsOptional();
            Property(x => x.CreditCardApprovalCode).HasColumnName("CreditCardApprovalCode").IsOptional().HasMaxLength(15);
            Property(x => x.CurrencyRateId).HasColumnName("CurrencyRateID").IsOptional();
            Property(x => x.SubTotal).HasColumnName("SubTotal").IsRequired().HasPrecision(19,4);
            Property(x => x.TaxAmt).HasColumnName("TaxAmt").IsRequired().HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName("Freight").IsRequired().HasPrecision(19,4);
            Property(x => x.TotalDue).HasColumnName("TotalDue").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Comment).HasColumnName("Comment").IsOptional().HasMaxLength(128);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_Customer).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.CustomerId); // FK_SalesOrderHeader_Customer_CustomerID
            HasRequired(a => a.Person_Contact).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.ContactId); // FK_SalesOrderHeader_Contact_ContactID
            HasOptional(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.SalesPersonId); // FK_SalesOrderHeader_SalesPerson_SalesPersonID
            HasOptional(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.TerritoryId); // FK_SalesOrderHeader_SalesTerritory_TerritoryID
            HasRequired(a => a.Person_Address).WithMany(b => b.BillToSalesOrderHeaders).HasForeignKey(c => c.BillToAddressId); // FK_SalesOrderHeader_Address_BillToAddressID
            HasRequired(a => a.Person_Address1).WithMany(b => b.ShipToSalesOrderHeaders).HasForeignKey(c => c.ShipToAddressId); // FK_SalesOrderHeader_Address_ShipToAddressID
            HasRequired(a => a.Purchasing_ShipMethod).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.ShipMethodId); // FK_SalesOrderHeader_ShipMethod_ShipMethodID
            HasOptional(a => a.Sales_CreditCard).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.CreditCardId); // FK_SalesOrderHeader_CreditCard_CreditCardID
            HasOptional(a => a.Sales_CurrencyRate).WithMany(b => b.Sales_SalesOrderHeader).HasForeignKey(c => c.CurrencyRateId); // FK_SalesOrderHeader_CurrencyRate_CurrencyRateID
        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.DataAccess.Configurations.Sales
{
    internal class Sales_CustomerAddressConfiguration : EntityTypeConfiguration<Sales_CustomerAddress>
    {
        public Sales_CustomerAddressConfiguration()
        {
            ToTable("Sales.CustomerAddress");
            HasKey(x => new { x.AddressId, x.CustomerId });

            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressId).HasColumnName("AddressID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressTypeId).HasColumnName("AddressTypeID").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_Customer).WithMany(b => b.Sales_CustomerAddress).HasForeignKey(c => c.CustomerId); // FK_CustomerAddress_Customer_CustomerID
            HasRequired(a => a.Person_Address).WithMany(b => b.Sales_CustomerAddress).HasForeignKey(c => c.AddressId); // FK_CustomerAddress_Address_AddressID
            HasRequired(a => a.Person_AddressType).WithMany(b => b.Sales_CustomerAddress).HasForeignKey(c => c.AddressTypeId); // FK_CustomerAddress_AddressType_AddressTypeID
        }
    }
}
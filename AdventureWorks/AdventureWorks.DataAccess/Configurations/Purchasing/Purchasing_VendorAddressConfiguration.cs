using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Purchasing;

namespace AdventureWorks.DataAccess.Configurations.Purchasing
{
    internal class Purchasing_VendorAddressConfiguration : EntityTypeConfiguration<Purchasing_VendorAddress>
    {
        public Purchasing_VendorAddressConfiguration()
        {
            ToTable("Purchasing.VendorAddress");
            HasKey(x => new { x.AddressId, x.VendorId });

            Property(x => x.VendorId).HasColumnName("VendorID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressId).HasColumnName("AddressID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressTypeId).HasColumnName("AddressTypeID").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Purchasing_Vendor).WithMany(b => b.Purchasing_VendorAddress).HasForeignKey(c => c.VendorId); // FK_VendorAddress_Vendor_VendorID
            HasRequired(a => a.Person_Address).WithMany(b => b.VendorAddresses).HasForeignKey(c => c.AddressId); // FK_VendorAddress_Address_AddressID
            HasRequired(a => a.Person_AddressType).WithMany(b => b.Purchasing_VendorAddress).HasForeignKey(c => c.AddressTypeId); // FK_VendorAddress_AddressType_AddressTypeID
        }
    }
}
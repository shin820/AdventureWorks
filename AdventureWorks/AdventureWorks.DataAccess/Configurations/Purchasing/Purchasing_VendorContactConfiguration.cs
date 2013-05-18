using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Purchasing;

namespace AdventureWorks.DataAccess.Configurations.Purchasing
{
    internal class Purchasing_VendorContactConfiguration : EntityTypeConfiguration<Purchasing_VendorContact>
    {
        public Purchasing_VendorContactConfiguration()
        {
            ToTable("Purchasing.VendorContact");
            HasKey(x => new { x.ContactId, x.VendorId });

            Property(x => x.VendorId).HasColumnName("VendorID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactId).HasColumnName("ContactID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactTypeId).HasColumnName("ContactTypeID").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Purchasing_Vendor).WithMany(b => b.Purchasing_VendorContact).HasForeignKey(c => c.VendorId); // FK_VendorContact_Vendor_VendorID
            HasRequired(a => a.Person_Contact).WithMany(b => b.Purchasing_VendorContact).HasForeignKey(c => c.ContactId); // FK_VendorContact_Contact_ContactID
            HasRequired(a => a.Person_ContactType).WithMany(b => b.Purchasing_VendorContact).HasForeignKey(c => c.ContactTypeId); // FK_VendorContact_ContactType_ContactTypeID
        }
    }
}
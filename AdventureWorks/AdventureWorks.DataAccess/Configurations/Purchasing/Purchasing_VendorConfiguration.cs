using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Purchasing;

namespace AdventureWorks.DataAccess.Configurations.Purchasing
{
    internal class Purchasing_VendorConfiguration : EntityTypeConfiguration<Purchasing_Vendor>
    {
        public Purchasing_VendorConfiguration()
        {
            ToTable("Purchasing.Vendor");
            HasKey(x => x.VendorId);

            Property(x => x.VendorId).HasColumnName("VendorID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsRequired().HasMaxLength(15);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CreditRating).HasColumnName("CreditRating").IsRequired();
            Property(x => x.PreferredVendorStatus).HasColumnName("PreferredVendorStatus").IsRequired();
            Property(x => x.ActiveFlag).HasColumnName("ActiveFlag").IsRequired();
            Property(x => x.PurchasingWebServiceUrl).HasColumnName("PurchasingWebServiceURL").IsOptional().HasMaxLength(1024);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
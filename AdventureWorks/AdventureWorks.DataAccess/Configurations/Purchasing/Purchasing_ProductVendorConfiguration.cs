using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Purchasing;

namespace AdventureWorks.DataAccess.Configurations.Purchasing
{
    internal class Purchasing_ProductVendorConfiguration : EntityTypeConfiguration<Purchasing_ProductVendor>
    {
        public Purchasing_ProductVendorConfiguration()
        {
            ToTable("Purchasing.ProductVendor");
            HasKey(x => new { x.ProductId, x.VendorId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.VendorId).HasColumnName("VendorID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AverageLeadTime).HasColumnName("AverageLeadTime").IsRequired();
            Property(x => x.StandardPrice).HasColumnName("StandardPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.LastReceiptCost).HasColumnName("LastReceiptCost").IsOptional().HasPrecision(19,4);
            Property(x => x.LastReceiptDate).HasColumnName("LastReceiptDate").IsOptional();
            Property(x => x.MinOrderQty).HasColumnName("MinOrderQty").IsRequired();
            Property(x => x.MaxOrderQty).HasColumnName("MaxOrderQty").IsRequired();
            Property(x => x.OnOrderQty).HasColumnName("OnOrderQty").IsOptional();
            Property(x => x.UnitMeasureCode).HasColumnName("UnitMeasureCode").IsRequired().HasMaxLength(3);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Purchasing_ProductVendor).HasForeignKey(c => c.ProductId); // FK_ProductVendor_Product_ProductID
            HasRequired(a => a.Purchasing_Vendor).WithMany(b => b.Purchasing_ProductVendor).HasForeignKey(c => c.VendorId); // FK_ProductVendor_Vendor_VendorID
            HasRequired(a => a.Production_UnitMeasure).WithMany(b => b.Purchasing_ProductVendor).HasForeignKey(c => c.UnitMeasureCode); // FK_ProductVendor_UnitMeasure_UnitMeasureCode
        }
    }
}
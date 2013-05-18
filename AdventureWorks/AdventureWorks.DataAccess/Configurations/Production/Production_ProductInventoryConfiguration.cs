using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_ProductInventoryConfiguration : EntityTypeConfiguration<Production_ProductInventory>
    {
        public Production_ProductInventoryConfiguration()
        {
            ToTable("Production.ProductInventory");
            HasKey(x => new { x.LocationId, x.ProductId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Shelf).HasColumnName("Shelf").IsRequired().HasMaxLength(10);
            Property(x => x.Bin).HasColumnName("Bin").IsRequired();
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductInventory).HasForeignKey(c => c.ProductId); // FK_ProductInventory_Product_ProductID
            HasRequired(a => a.Production_Location).WithMany(b => b.Production_ProductInventory).HasForeignKey(c => c.LocationId); // FK_ProductInventory_Location_LocationID
        }
    }
}
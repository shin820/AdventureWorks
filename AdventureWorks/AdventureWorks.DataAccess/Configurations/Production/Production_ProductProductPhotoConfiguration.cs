using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_ProductProductPhotoConfiguration : EntityTypeConfiguration<Production_ProductProductPhoto>
    {
        public Production_ProductProductPhotoConfiguration()
        {
            ToTable("Production.ProductProductPhoto");
            HasKey(x => new { x.ProductId, x.ProductPhotoId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductPhotoId).HasColumnName("ProductPhotoID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Primary).HasColumnName("Primary").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductProductPhoto).HasForeignKey(c => c.ProductId); // FK_ProductProductPhoto_Product_ProductID
            HasRequired(a => a.Production_ProductPhoto).WithMany(b => b.Production_ProductProductPhoto).HasForeignKey(c => c.ProductPhotoId); // FK_ProductProductPhoto_ProductPhoto_ProductPhotoID
        }
    }
}
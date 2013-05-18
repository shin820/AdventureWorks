using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_ProductModelProductDescriptionCultureConfiguration : EntityTypeConfiguration<Production_ProductModelProductDescriptionCulture>
    {
        public Production_ProductModelProductDescriptionCultureConfiguration()
        {
            ToTable("Production.ProductModelProductDescriptionCulture");
            HasKey(x => new { x.CultureId, x.ProductDescriptionId, x.ProductModelId });

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductDescriptionId).HasColumnName("ProductDescriptionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CultureId).HasColumnName("CultureID").IsRequired().HasMaxLength(6);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_ProductModel).WithMany(b => b.Production_ProductModelProductDescriptionCulture).HasForeignKey(c => c.ProductModelId); // FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID
            HasRequired(a => a.Production_ProductDescription).WithMany(b => b.Production_ProductModelProductDescriptionCulture).HasForeignKey(c => c.ProductDescriptionId); // FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID
            HasRequired(a => a.Production_Culture).WithMany(b => b.Production_ProductModelProductDescriptionCulture).HasForeignKey(c => c.CultureId); // FK_ProductModelProductDescriptionCulture_Culture_CultureID
        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_ProductSubcategoryConfiguration : EntityTypeConfiguration<Production_ProductSubcategory>
    {
        public Production_ProductSubcategoryConfiguration()
        {
            ToTable("Production.ProductSubcategory");
            HasKey(x => x.ProductSubcategoryId);

            Property(x => x.ProductSubcategoryId).HasColumnName("ProductSubcategoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductCategoryId).HasColumnName("ProductCategoryID").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_ProductCategory).WithMany(b => b.Production_ProductSubcategory).HasForeignKey(c => c.ProductCategoryId); // FK_ProductSubcategory_ProductCategory_ProductCategoryID
        }
    }
}
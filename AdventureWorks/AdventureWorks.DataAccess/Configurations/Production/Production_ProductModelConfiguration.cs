using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_ProductModelConfiguration : EntityTypeConfiguration<Production_ProductModel>
    {
        public Production_ProductModelConfiguration()
        {
            ToTable("Production.ProductModel");
            HasKey(x => x.ProductModelId);

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CatalogDescription).HasColumnName("CatalogDescription").IsOptional();
            Property(x => x.Instructions).HasColumnName("Instructions").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_ProductDescriptionConfiguration : EntityTypeConfiguration<Production_ProductDescription>
    {
        public Production_ProductDescriptionConfiguration()
        {
            ToTable("Production.ProductDescription");
            HasKey(x => x.ProductDescriptionId);

            Property(x => x.ProductDescriptionId).HasColumnName("ProductDescriptionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName("Description").IsRequired().HasMaxLength(400);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
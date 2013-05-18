using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_ProductModelIllustrationConfiguration : EntityTypeConfiguration<Production_ProductModelIllustration>
    {
        public Production_ProductModelIllustrationConfiguration()
        {
            ToTable("Production.ProductModelIllustration");
            HasKey(x => new { x.IllustrationId, x.ProductModelId });

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IllustrationId).HasColumnName("IllustrationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_ProductModel).WithMany(b => b.Production_ProductModelIllustration).HasForeignKey(c => c.ProductModelId); // FK_ProductModelIllustration_ProductModel_ProductModelID
            HasRequired(a => a.Production_Illustration).WithMany(b => b.Production_ProductModelIllustration).HasForeignKey(c => c.IllustrationId); // FK_ProductModelIllustration_Illustration_IllustrationID
        }
    }
}
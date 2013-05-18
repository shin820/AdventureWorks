using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_ScrapReasonConfiguration : EntityTypeConfiguration<Production_ScrapReason>
    {
        public Production_ScrapReasonConfiguration()
        {
            ToTable("Production.ScrapReason");
            HasKey(x => x.ScrapReasonId);

            Property(x => x.ScrapReasonId).HasColumnName("ScrapReasonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
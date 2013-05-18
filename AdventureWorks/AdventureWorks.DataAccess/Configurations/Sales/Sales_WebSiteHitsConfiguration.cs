using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.DataAccess.Configurations.Sales
{
    internal class Sales_WebSiteHitsConfiguration : EntityTypeConfiguration<Sales_WebSiteHits>
    {
        public Sales_WebSiteHitsConfiguration()
        {
            ToTable("Sales.WebSiteHits");
            HasKey(x => new { x.HitDate, x.WebSiteHitId });

            Property(x => x.WebSiteHitId).HasColumnName("WebSiteHitID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.WebSitePage).HasColumnName("WebSitePage").IsRequired().HasMaxLength(255);
            Property(x => x.HitDate).HasColumnName("HitDate").IsRequired();
        }
    }
}
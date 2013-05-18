using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_CultureConfiguration : EntityTypeConfiguration<Production_Culture>
    {
        public Production_CultureConfiguration()
        {
            ToTable("Production.Culture");
            HasKey(x => x.CultureId);

            Property(x => x.CultureId).HasColumnName("CultureID").IsRequired().HasMaxLength(6);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
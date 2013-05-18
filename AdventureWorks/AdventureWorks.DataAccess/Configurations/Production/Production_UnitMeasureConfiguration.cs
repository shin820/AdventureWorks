using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_UnitMeasureConfiguration : EntityTypeConfiguration<Production_UnitMeasure>
    {
        public Production_UnitMeasureConfiguration()
        {
            ToTable("Production.UnitMeasure");
            HasKey(x => x.UnitMeasureCode);

            Property(x => x.UnitMeasureCode).HasColumnName("UnitMeasureCode").IsRequired().HasMaxLength(3);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
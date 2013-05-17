using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.HumanResources;

namespace AdventureWorks.DataAccess.Configurations.HumanResources
{
    internal class HumanResources_ShiftConfiguration : EntityTypeConfiguration<HumanResources_Shift>
    {
        public HumanResources_ShiftConfiguration()
        {
            ToTable("HumanResources.Shift");
            HasKey(x => x.ShiftId);

            Property(x => x.ShiftId).HasColumnName("ShiftID").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.StartTime).HasColumnName("StartTime").IsRequired();
            Property(x => x.EndTime).HasColumnName("EndTime").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
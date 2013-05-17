using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model;

namespace AdventureWorks.DataAccess.Configurations
{
    internal class AwBuildVersionConfiguration : EntityTypeConfiguration<AwBuildVersion>
    {
        public AwBuildVersionConfiguration()
        {
            ToTable("dbo.AWBuildVersion");
            HasKey(x => x.SystemInformationId);

            Property(x => x.SystemInformationId).HasColumnName("SystemInformationID").IsRequired();
            Property(x => x.DatabaseVersion).HasColumnName("Database Version").IsRequired().HasMaxLength(25);
            Property(x => x.VersionDate).HasColumnName("VersionDate").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model;

namespace AdventureWorks.DataAccess.Configurations
{
    internal class DatabaseLogConfiguration : EntityTypeConfiguration<DatabaseLog>
    {
        public DatabaseLogConfiguration()
        {
            ToTable("dbo.DatabaseLog");
            HasKey(x => x.DatabaseLogId);

            Property(x => x.DatabaseLogId).HasColumnName("DatabaseLogID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PostTime).HasColumnName("PostTime").IsRequired();
            Property(x => x.DatabaseUser).HasColumnName("DatabaseUser").IsRequired().HasMaxLength(128);
            Property(x => x.Event).HasColumnName("Event").IsRequired().HasMaxLength(128);
            Property(x => x.Schema).HasColumnName("Schema").IsOptional().HasMaxLength(128);
            Property(x => x.Object).HasColumnName("Object").IsOptional().HasMaxLength(128);
            Property(x => x.Tsql).HasColumnName("TSQL").IsRequired();
            Property(x => x.XmlEvent).HasColumnName("XmlEvent").IsRequired();
        }
    }
}
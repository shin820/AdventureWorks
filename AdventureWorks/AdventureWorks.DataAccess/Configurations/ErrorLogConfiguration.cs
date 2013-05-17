using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model;

namespace AdventureWorks.DataAccess.Configurations
{
    internal class ErrorLogConfiguration : EntityTypeConfiguration<ErrorLog>
    {
        public ErrorLogConfiguration()
        {
            ToTable("dbo.ErrorLog");
            HasKey(x => x.ErrorLogId);

            Property(x => x.ErrorLogId).HasColumnName("ErrorLogID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ErrorTime).HasColumnName("ErrorTime").IsRequired();
            Property(x => x.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(128);
            Property(x => x.ErrorNumber).HasColumnName("ErrorNumber").IsRequired();
            Property(x => x.ErrorSeverity).HasColumnName("ErrorSeverity").IsOptional();
            Property(x => x.ErrorState).HasColumnName("ErrorState").IsOptional();
            Property(x => x.ErrorProcedure).HasColumnName("ErrorProcedure").IsOptional().HasMaxLength(126);
            Property(x => x.ErrorLine).HasColumnName("ErrorLine").IsOptional();
            Property(x => x.ErrorMessage).HasColumnName("ErrorMessage").IsRequired().HasMaxLength(4000);
        }
    }
}
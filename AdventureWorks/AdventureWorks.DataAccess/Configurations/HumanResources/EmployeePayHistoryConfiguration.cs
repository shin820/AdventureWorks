using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.HumanResources;

namespace AdventureWorks.DataAccess.Configurations.HumanResources
{
    internal class EmployeePayHistoryConfiguration : EntityTypeConfiguration<EmployeePayHistory>
    {
        public EmployeePayHistoryConfiguration()
        {
            ToTable("HumanResources.EmployeePayHistory");
            HasKey(x => new { x.EmployeeId, x.RateChangeDate });

            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.RateChangeDate).HasColumnName("RateChangeDate").IsRequired();
            Property(x => x.Rate).HasColumnName("Rate").IsRequired().HasPrecision(19,4);
            Property(x => x.PayFrequency).HasColumnName("PayFrequency").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Employee).WithMany(b => b.EmployeePayHistories).HasForeignKey(c => c.EmployeeId); // FK_EmployeePayHistory_Employee_EmployeeID
        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.DataAccess.Configurations.Sales
{
    internal class Sales_SalesPersonQuotaHistoryConfiguration : EntityTypeConfiguration<Sales_SalesPersonQuotaHistory>
    {
        public Sales_SalesPersonQuotaHistoryConfiguration()
        {
            ToTable("Sales.SalesPersonQuotaHistory");
            HasKey(x => new { x.QuotaDate, x.SalesPersonId });

            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.QuotaDate).HasColumnName("QuotaDate").IsRequired();
            Property(x => x.SalesQuota).HasColumnName("SalesQuota").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesPersonQuotaHistory).HasForeignKey(c => c.SalesPersonId); // FK_SalesPersonQuotaHistory_SalesPerson_SalesPersonID
        }
    }
}
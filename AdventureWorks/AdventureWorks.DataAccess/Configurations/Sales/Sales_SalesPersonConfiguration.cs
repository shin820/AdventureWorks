using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.DataAccess.Configurations.Sales
{
    internal class Sales_SalesPersonConfiguration : EntityTypeConfiguration<Sales_SalesPerson>
    {
        public Sales_SalesPersonConfiguration()
        {
            ToTable("Sales.SalesPerson");
            HasKey(x => x.SalesPersonId);

            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.SalesQuota).HasColumnName("SalesQuota").IsOptional().HasPrecision(19,4);
            Property(x => x.Bonus).HasColumnName("Bonus").IsRequired().HasPrecision(19,4);
            Property(x => x.CommissionPct).HasColumnName("CommissionPct").IsRequired().HasPrecision(10,4);
            Property(x => x.SalesYtd).HasColumnName("SalesYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.SalesLastYear).HasColumnName("SalesLastYear").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Employee).WithOptional(b => b.SalesPersons); // FK_SalesPerson_Employee_SalesPersonID
            HasOptional(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_SalesPerson).HasForeignKey(c => c.TerritoryId); // FK_SalesPerson_SalesTerritory_TerritoryID
        }
    }
}
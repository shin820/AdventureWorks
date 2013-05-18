using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.DataAccess.Configurations.Sales
{
    internal class Sales_SalesTerritoryHistoryConfiguration : EntityTypeConfiguration<Sales_SalesTerritoryHistory>
    {
        public Sales_SalesTerritoryHistoryConfiguration()
        {
            ToTable("Sales.SalesTerritoryHistory");
            HasKey(x => new { x.SalesPersonId, x.StartDate, x.TerritoryId });

            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesTerritoryHistory).HasForeignKey(c => c.SalesPersonId); // FK_SalesTerritoryHistory_SalesPerson_SalesPersonID
            HasRequired(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_SalesTerritoryHistory).HasForeignKey(c => c.TerritoryId); // FK_SalesTerritoryHistory_SalesTerritory_TerritoryID
        }
    }
}
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.DataAccess.Configurations.Sales
{
    internal class Sales_CountryRegionCurrencyConfiguration : EntityTypeConfiguration<Sales_CountryRegionCurrency>
    {
        public Sales_CountryRegionCurrencyConfiguration()
        {
            ToTable("Sales.CountryRegionCurrency");
            HasKey(x => new { x.CountryRegionCode, x.CurrencyCode });

            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3);
            Property(x => x.CurrencyCode).HasColumnName("CurrencyCode").IsRequired().HasMaxLength(3);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.CountryRegion).WithMany(b => b.Sales_CountryRegionCurrency).HasForeignKey(c => c.CountryRegionCode); // FK_CountryRegionCurrency_CountryRegion_CountryRegionCode
            HasRequired(a => a.Sales_Currency).WithMany(b => b.Sales_CountryRegionCurrency).HasForeignKey(c => c.CurrencyCode); // FK_CountryRegionCurrency_Currency_CurrencyCode
        }
    }
}
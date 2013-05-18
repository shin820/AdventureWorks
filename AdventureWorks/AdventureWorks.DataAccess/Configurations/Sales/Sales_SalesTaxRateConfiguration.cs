using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.DataAccess.Configurations.Sales
{
    internal class Sales_SalesTaxRateConfiguration : EntityTypeConfiguration<Sales_SalesTaxRate>
    {
        public Sales_SalesTaxRateConfiguration()
        {
            ToTable("Sales.SalesTaxRate");
            HasKey(x => x.SalesTaxRateId);

            Property(x => x.SalesTaxRateId).HasColumnName("SalesTaxRateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceId).HasColumnName("StateProvinceID").IsRequired();
            Property(x => x.TaxType).HasColumnName("TaxType").IsRequired();
            Property(x => x.TaxRate).HasColumnName("TaxRate").IsRequired().HasPrecision(10,4);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.StateProvince).WithMany(b => b.Sales_SalesTaxRate).HasForeignKey(c => c.StateProvinceId); // FK_SalesTaxRate_StateProvince_StateProvinceID
        }
    }
}
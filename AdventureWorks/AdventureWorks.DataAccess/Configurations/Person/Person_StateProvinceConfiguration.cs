using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Person;

namespace AdventureWorks.DataAccess.Configurations.Person
{
    internal class Person_StateProvinceConfiguration : EntityTypeConfiguration<StateProvince>
    {
        public Person_StateProvinceConfiguration()
        {
            ToTable("Person.StateProvince");
            HasKey(x => x.StateProvinceId);

            Property(x => x.StateProvinceId).HasColumnName("StateProvinceID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceCode).HasColumnName("StateProvinceCode").IsRequired().HasMaxLength(3);
            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3);
            Property(x => x.IsOnlyStateProvinceFlag).HasColumnName("IsOnlyStateProvinceFlag").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.CountryRegion).WithMany(b => b.Person_StateProvince).HasForeignKey(c => c.CountryRegionCode); // FK_StateProvince_CountryRegion_CountryRegionCode
            HasRequired(a => a.Sales_SalesTerritory).WithMany(b => b.Person_StateProvince).HasForeignKey(c => c.TerritoryId); // FK_StateProvince_SalesTerritory_TerritoryID
        }
    }
}
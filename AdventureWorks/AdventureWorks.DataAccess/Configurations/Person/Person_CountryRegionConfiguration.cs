using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Person;

namespace AdventureWorks.DataAccess.Configurations.Person
{
    internal class Person_CountryRegionConfiguration : EntityTypeConfiguration<CountryRegion>
    {
        public Person_CountryRegionConfiguration()
        {
            ToTable("Person.CountryRegion");
            HasKey(x => x.CountryRegionCode);

            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
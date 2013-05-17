using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Person;

namespace AdventureWorks.DataAccess.Configurations.Person
{
    internal class Person_AddressTypeConfiguration : EntityTypeConfiguration<Person_AddressType>
    {
        public Person_AddressTypeConfiguration()
        {
            ToTable("Person.AddressType");
            HasKey(x => x.AddressTypeId);

            Property(x => x.AddressTypeId).HasColumnName("AddressTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
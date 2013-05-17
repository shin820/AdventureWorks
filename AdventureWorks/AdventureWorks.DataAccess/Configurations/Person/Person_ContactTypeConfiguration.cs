using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Person;

namespace AdventureWorks.DataAccess.Configurations.Person
{
    internal class Person_ContactTypeConfiguration : EntityTypeConfiguration<Person_ContactType>
    {
        public Person_ContactTypeConfiguration()
        {
            ToTable("Person.ContactType");
            HasKey(x => x.ContactTypeId);

            Property(x => x.ContactTypeId).HasColumnName("ContactTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
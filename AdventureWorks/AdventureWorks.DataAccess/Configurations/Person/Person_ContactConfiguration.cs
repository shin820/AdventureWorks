using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Person;

namespace AdventureWorks.DataAccess.Configurations.Person
{
    internal class Person_ContactConfiguration : EntityTypeConfiguration<Person_Contact>
    {
        public Person_ContactConfiguration()
        {
            ToTable("Person.Contact");
            HasKey(x => x.ContactId);

            Property(x => x.ContactId).HasColumnName("ContactID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.NameStyle).HasColumnName("NameStyle").IsRequired();
            Property(x => x.Title).HasColumnName("Title").IsOptional().HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            Property(x => x.MiddleName).HasColumnName("MiddleName").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            Property(x => x.Suffix).HasColumnName("Suffix").IsOptional().HasMaxLength(10);
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsOptional().HasMaxLength(50);
            Property(x => x.EmailPromotion).HasColumnName("EmailPromotion").IsRequired();
            Property(x => x.Phone).HasColumnName("Phone").IsOptional().HasMaxLength(25);
            Property(x => x.PasswordHash).HasColumnName("PasswordHash").IsRequired().HasMaxLength(128);
            Property(x => x.PasswordSalt).HasColumnName("PasswordSalt").IsRequired().HasMaxLength(10);
            Property(x => x.AdditionalContactInfo).HasColumnName("AdditionalContactInfo").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
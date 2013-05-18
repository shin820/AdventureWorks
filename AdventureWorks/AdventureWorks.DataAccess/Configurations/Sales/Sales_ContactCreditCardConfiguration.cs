using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.DataAccess.Configurations.Sales
{
    internal class Sales_ContactCreditCardConfiguration : EntityTypeConfiguration<Sales_ContactCreditCard>
    {
        public Sales_ContactCreditCardConfiguration()
        {
            ToTable("Sales.ContactCreditCard");
            HasKey(x => new { x.ContactId, x.CreditCardId });

            Property(x => x.ContactId).HasColumnName("ContactID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_Contact).WithMany(b => b.Sales_ContactCreditCard).HasForeignKey(c => c.ContactId); // FK_ContactCreditCard_Contact_ContactID
            HasRequired(a => a.Sales_CreditCard).WithMany(b => b.Sales_ContactCreditCard).HasForeignKey(c => c.CreditCardId); // FK_ContactCreditCard_CreditCard_CreditCardID
        }
    }
}
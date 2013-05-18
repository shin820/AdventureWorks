using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.DataAccess.Configurations.Sales
{
    internal class Sales_IndividualConfiguration : EntityTypeConfiguration<Sales_Individual>
    {
        public Sales_IndividualConfiguration()
        {
            ToTable("Sales.Individual");
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactId).HasColumnName("ContactID").IsRequired();
            Property(x => x.Demographics).HasColumnName("Demographics").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_Customer).WithOptional(b => b.Sales_Individual); // FK_Individual_Customer_CustomerID
            HasRequired(a => a.Person_Contact).WithMany(b => b.Sales_Individual).HasForeignKey(c => c.ContactId); // FK_Individual_Contact_ContactID
        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.DataAccess.Configurations.Sales
{
    internal class Sales_StoreContactConfiguration : EntityTypeConfiguration<Sales_StoreContact>
    {
        public Sales_StoreContactConfiguration()
        {
            ToTable("Sales.StoreContact");
            HasKey(x => new { x.ContactId, x.CustomerId });

            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactId).HasColumnName("ContactID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactTypeId).HasColumnName("ContactTypeID").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_Store).WithMany(b => b.Sales_StoreContact).HasForeignKey(c => c.CustomerId); // FK_StoreContact_Store_CustomerID
            HasRequired(a => a.Person_Contact).WithMany(b => b.Sales_StoreContact).HasForeignKey(c => c.ContactId); // FK_StoreContact_Contact_ContactID
            HasRequired(a => a.Person_ContactType).WithMany(b => b.Sales_StoreContact).HasForeignKey(c => c.ContactTypeId); // FK_StoreContact_ContactType_ContactTypeID
        }
    }
}
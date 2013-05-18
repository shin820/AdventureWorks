using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_TransactionHistoryConfiguration : EntityTypeConfiguration<Production_TransactionHistory>
    {
        public Production_TransactionHistoryConfiguration()
        {
            ToTable("Production.TransactionHistory");
            HasKey(x => x.TransactionId);

            Property(x => x.TransactionId).HasColumnName("TransactionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ReferenceOrderId).HasColumnName("ReferenceOrderID").IsRequired();
            Property(x => x.ReferenceOrderLineId).HasColumnName("ReferenceOrderLineID").IsRequired();
            Property(x => x.TransactionDate).HasColumnName("TransactionDate").IsRequired();
            Property(x => x.TransactionType).HasColumnName("TransactionType").IsRequired().HasMaxLength(1);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_TransactionHistory).HasForeignKey(c => c.ProductId); // FK_TransactionHistory_Product_ProductID
        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Purchasing;

namespace AdventureWorks.DataAccess.Configurations.Purchasing
{
    internal class Purchasing_PurchaseOrderDetailConfiguration : EntityTypeConfiguration<Purchasing_PurchaseOrderDetail>
    {
        public Purchasing_PurchaseOrderDetailConfiguration()
        {
            ToTable("Purchasing.PurchaseOrderDetail");
            HasKey(x => new { x.PurchaseOrderDetailId, x.PurchaseOrderId });

            Property(x => x.PurchaseOrderId).HasColumnName("PurchaseOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PurchaseOrderDetailId).HasColumnName("PurchaseOrderDetailID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.OrderQty).HasColumnName("OrderQty").IsRequired();
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.LineTotal).HasColumnName("LineTotal").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ReceivedQty).HasColumnName("ReceivedQty").IsRequired().HasPrecision(8,2);
            Property(x => x.RejectedQty).HasColumnName("RejectedQty").IsRequired().HasPrecision(8,2);
            Property(x => x.StockedQty).HasColumnName("StockedQty").IsRequired().HasPrecision(9,2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Purchasing_PurchaseOrderHeader).WithMany(b => b.Purchasing_PurchaseOrderDetail).HasForeignKey(c => c.PurchaseOrderId); // FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID
            HasRequired(a => a.Production_Product).WithMany(b => b.Purchasing_PurchaseOrderDetail).HasForeignKey(c => c.ProductId); // FK_PurchaseOrderDetail_Product_ProductID
        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_WorkOrderConfiguration : EntityTypeConfiguration<Production_WorkOrder>
    {
        public Production_WorkOrderConfiguration()
        {
            ToTable("Production.WorkOrder");
            HasKey(x => x.WorkOrderId);

            Property(x => x.WorkOrderId).HasColumnName("WorkOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.OrderQty).HasColumnName("OrderQty").IsRequired();
            Property(x => x.StockedQty).HasColumnName("StockedQty").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ScrappedQty).HasColumnName("ScrappedQty").IsRequired();
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.ScrapReasonId).HasColumnName("ScrapReasonID").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_WorkOrder).HasForeignKey(c => c.ProductId); // FK_WorkOrder_Product_ProductID
            HasOptional(a => a.Production_ScrapReason).WithMany(b => b.Production_WorkOrder).HasForeignKey(c => c.ScrapReasonId); // FK_WorkOrder_ScrapReason_ScrapReasonID
        }
    }
}
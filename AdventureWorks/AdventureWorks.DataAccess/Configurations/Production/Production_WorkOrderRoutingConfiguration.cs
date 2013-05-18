using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_WorkOrderRoutingConfiguration : EntityTypeConfiguration<Production_WorkOrderRouting>
    {
        public Production_WorkOrderRoutingConfiguration()
        {
            ToTable("Production.WorkOrderRouting");
            HasKey(x => new { x.OperationSequence, x.ProductId, x.WorkOrderId });

            Property(x => x.WorkOrderId).HasColumnName("WorkOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.OperationSequence).HasColumnName("OperationSequence").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired();
            Property(x => x.ScheduledStartDate).HasColumnName("ScheduledStartDate").IsRequired();
            Property(x => x.ScheduledEndDate).HasColumnName("ScheduledEndDate").IsRequired();
            Property(x => x.ActualStartDate).HasColumnName("ActualStartDate").IsOptional();
            Property(x => x.ActualEndDate).HasColumnName("ActualEndDate").IsOptional();
            Property(x => x.ActualResourceHrs).HasColumnName("ActualResourceHrs").IsOptional().HasPrecision(9,4);
            Property(x => x.PlannedCost).HasColumnName("PlannedCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsOptional().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_WorkOrder).WithMany(b => b.Production_WorkOrderRouting).HasForeignKey(c => c.WorkOrderId); // FK_WorkOrderRouting_WorkOrder_WorkOrderID
            HasRequired(a => a.Production_Location).WithMany(b => b.Production_WorkOrderRouting).HasForeignKey(c => c.LocationId); // FK_WorkOrderRouting_Location_LocationID
        }
    }
}
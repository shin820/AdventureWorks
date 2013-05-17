using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.HumanResources;

namespace AdventureWorks.DataAccess.Configurations.HumanResources
{
    internal class HumanResources_EmployeeDepartmentHistoryConfiguration : EntityTypeConfiguration<HumanResources_EmployeeDepartmentHistory>
    {
        public HumanResources_EmployeeDepartmentHistoryConfiguration()
        {
            ToTable("HumanResources.EmployeeDepartmentHistory");
            HasKey(x => new { x.DepartmentId, x.EmployeeId, x.ShiftId, x.StartDate });

            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DepartmentId).HasColumnName("DepartmentID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ShiftId).HasColumnName("ShiftID").IsRequired();
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.HumanResources_Employee).WithMany(b => b.HumanResources_EmployeeDepartmentHistory).HasForeignKey(c => c.EmployeeId); // FK_EmployeeDepartmentHistory_Employee_EmployeeID
            HasRequired(a => a.HumanResources_Department).WithMany(b => b.HumanResources_EmployeeDepartmentHistory).HasForeignKey(c => c.DepartmentId); // FK_EmployeeDepartmentHistory_Department_DepartmentID
            HasRequired(a => a.HumanResources_Shift).WithMany(b => b.HumanResources_EmployeeDepartmentHistory).HasForeignKey(c => c.ShiftId); // FK_EmployeeDepartmentHistory_Shift_ShiftID
        }
    }
}
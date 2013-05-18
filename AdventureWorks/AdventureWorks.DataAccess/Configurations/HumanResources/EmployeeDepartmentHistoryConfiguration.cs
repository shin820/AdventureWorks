using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.HumanResources;

namespace AdventureWorks.DataAccess.Configurations.HumanResources
{
    internal class EmployeeDepartmentHistoryConfiguration : EntityTypeConfiguration<EmployeeDepartmentHistory>
    {
        public EmployeeDepartmentHistoryConfiguration()
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
            HasRequired(a => a.Employee).WithMany(b => b.EmployeeDepartmentHistories).HasForeignKey(c => c.EmployeeId); // FK_EmployeeDepartmentHistory_Employee_EmployeeID
            HasRequired(a => a.Department).WithMany(b => b.HumanResources_EmployeeDepartmentHistory).HasForeignKey(c => c.DepartmentId); // FK_EmployeeDepartmentHistory_Department_DepartmentID
            HasRequired(a => a.Shift).WithMany(b => b.HumanResources_EmployeeDepartmentHistory).HasForeignKey(c => c.ShiftId); // FK_EmployeeDepartmentHistory_Shift_ShiftID
        }
    }
}
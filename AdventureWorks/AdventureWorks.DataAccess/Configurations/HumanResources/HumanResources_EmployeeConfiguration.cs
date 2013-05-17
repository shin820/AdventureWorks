using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.HumanResources;

namespace AdventureWorks.DataAccess.Configurations.HumanResources
{
    internal class HumanResources_EmployeeConfiguration : EntityTypeConfiguration<HumanResources_Employee>
    {
        public HumanResources_EmployeeConfiguration()
        {
            ToTable("HumanResources.Employee");
            HasKey(x => x.EmployeeId);

            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.NationalIdNumber).HasColumnName("NationalIDNumber").IsRequired().HasMaxLength(15);
            Property(x => x.ContactId).HasColumnName("ContactID").IsRequired();
            Property(x => x.LoginId).HasColumnName("LoginID").IsRequired().HasMaxLength(256);
            Property(x => x.ManagerId).HasColumnName("ManagerID").IsOptional();
            Property(x => x.Title).HasColumnName("Title").IsRequired().HasMaxLength(50);
            Property(x => x.BirthDate).HasColumnName("BirthDate").IsRequired();
            Property(x => x.MaritalStatus).HasColumnName("MaritalStatus").IsRequired().HasMaxLength(1);
            Property(x => x.Gender).HasColumnName("Gender").IsRequired().HasMaxLength(1);
            Property(x => x.HireDate).HasColumnName("HireDate").IsRequired();
            Property(x => x.SalariedFlag).HasColumnName("SalariedFlag").IsRequired();
            Property(x => x.VacationHours).HasColumnName("VacationHours").IsRequired();
            Property(x => x.SickLeaveHours).HasColumnName("SickLeaveHours").IsRequired();
            Property(x => x.CurrentFlag).HasColumnName("CurrentFlag").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Person_Contact).WithMany(b => b.HumanResources_Employee).HasForeignKey(c => c.ContactId); // FK_Employee_Contact_ContactID
            HasOptional(a => a.HumanResources_Employee1).WithMany(b => b.HumanResources_Employee2).HasForeignKey(c => c.ManagerId); // FK_Employee_Employee_ManagerID
        }
    }
}
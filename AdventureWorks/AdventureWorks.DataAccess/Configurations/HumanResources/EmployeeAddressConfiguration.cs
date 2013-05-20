using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.HumanResources;

namespace AdventureWorks.DataAccess.Configurations.HumanResources
{
    internal class EmployeeAddressConfiguration : EntityTypeConfiguration<EmployeeAddress>
    {
        public EmployeeAddressConfiguration()
        {
            ToTable("HumanResources.EmployeeAddress");
            HasKey(x => new { x.AddressId, x.EmployeeId });

            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressId).HasColumnName("AddressID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Employee).WithMany(b => b.EmployeeAddresses).HasForeignKey(c => c.EmployeeId); // FK_EmployeeAddress_Employee_EmployeeID
            HasRequired(a => a.PersonAddresses).WithMany(b => b.EmployeeAddresses).HasForeignKey(c => c.AddressId); // FK_EmployeeAddress_Address_AddressID
        }
    }
}
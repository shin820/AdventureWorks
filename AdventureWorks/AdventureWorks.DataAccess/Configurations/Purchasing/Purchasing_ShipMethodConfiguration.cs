using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Purchasing;

namespace AdventureWorks.DataAccess.Configurations.Purchasing
{
    internal class Purchasing_ShipMethodConfiguration : EntityTypeConfiguration<Purchasing_ShipMethod>
    {
        public Purchasing_ShipMethodConfiguration()
        {
            ToTable("Purchasing.ShipMethod");
            HasKey(x => x.ShipMethodId);

            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ShipBase).HasColumnName("ShipBase").IsRequired().HasPrecision(19,4);
            Property(x => x.ShipRate).HasColumnName("ShipRate").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}
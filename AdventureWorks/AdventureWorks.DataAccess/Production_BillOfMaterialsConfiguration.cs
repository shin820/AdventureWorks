using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.IntegrationTest
{
    internal class Production_BillOfMaterialsConfiguration : EntityTypeConfiguration<Production_BillOfMaterials>
    {
        public Production_BillOfMaterialsConfiguration()
        {
            ToTable("Production.BillOfMaterials");
            HasKey(x => x.BillOfMaterialsId);

            Property(x => x.BillOfMaterialsId).HasColumnName("BillOfMaterialsID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductAssemblyId).HasColumnName("ProductAssemblyID").IsOptional();
            Property(x => x.ComponentId).HasColumnName("ComponentID").IsRequired();
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.UnitMeasureCode).HasColumnName("UnitMeasureCode").IsRequired().HasMaxLength(3);
            Property(x => x.BomLevel).HasColumnName("BOMLevel").IsRequired();
            Property(x => x.PerAssemblyQty).HasColumnName("PerAssemblyQty").IsRequired().HasPrecision(8,2);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.Production_Product1).WithMany(b => b.Production_BillOfMaterials1).HasForeignKey(c => c.ProductAssemblyId); // FK_BillOfMaterials_Product_ProductAssemblyID
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_BillOfMaterials).HasForeignKey(c => c.ComponentId); // FK_BillOfMaterials_Product_ComponentID
            HasRequired(a => a.Production_UnitMeasure).WithMany(b => b.Production_BillOfMaterials).HasForeignKey(c => c.UnitMeasureCode); // FK_BillOfMaterials_UnitMeasure_UnitMeasureCode
        }
    }
}
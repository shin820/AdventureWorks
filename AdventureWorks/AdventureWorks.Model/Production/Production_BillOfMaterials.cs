using System;

namespace AdventureWorks.Model.Production
{
    public class Production_BillOfMaterials
    {
        public int BillOfMaterialsId { get; set; } // BillOfMaterialsID (Primary key)
        public int? ProductAssemblyId { get; set; } // ProductAssemblyID
        public int ComponentId { get; set; } // ComponentID
        public DateTime StartDate { get; set; } // StartDate
        public DateTime? EndDate { get; set; } // EndDate
        public string UnitMeasureCode { get; set; } // UnitMeasureCode
        public short BomLevel { get; set; } // BOMLevel
        public decimal PerAssemblyQty { get; set; } // PerAssemblyQty
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_Product Production_Product1 { get; set; } //  ProductAssemblyId - FK_BillOfMaterials_Product_ProductAssemblyID
        public virtual Production_Product Production_Product { get; set; } //  ComponentId - FK_BillOfMaterials_Product_ComponentID
        public virtual Production_UnitMeasure Production_UnitMeasure { get; set; } //  UnitMeasureCode - FK_BillOfMaterials_UnitMeasure_UnitMeasureCode

        public Production_BillOfMaterials()
        {
            StartDate = DateTime.Now;
            PerAssemblyQty = 1.00m;
            ModifiedDate = DateTime.Now;
        }
    }
}
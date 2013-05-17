using System;
using System.Collections.Generic;
using AdventureWorks.Model.Purchasing;

namespace AdventureWorks.Model.Production
{
    public class Production_UnitMeasure
    {
        public string UnitMeasureCode { get; set; } // UnitMeasureCode (Primary key)
        public string Name { get; set; } // Name
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_BillOfMaterials> Production_BillOfMaterials { get; set; } // BillOfMaterials.FK_BillOfMaterials_UnitMeasure_UnitMeasureCode;
        public virtual ICollection<Production_Product> Production_Product { get; set; } // Product.FK_Product_UnitMeasure_SizeUnitMeasureCode;
        public virtual ICollection<Production_Product> Production_Product1 { get; set; } // Product.FK_Product_UnitMeasure_WeightUnitMeasureCode;
        public virtual ICollection<Purchasing_ProductVendor> Purchasing_ProductVendor { get; set; } // ProductVendor.FK_ProductVendor_UnitMeasure_UnitMeasureCode;

        public Production_UnitMeasure()
        {
            ModifiedDate = DateTime.Now;
            Production_BillOfMaterials = new List<Production_BillOfMaterials>();
            Production_Product = new List<Production_Product>();
            Production_Product1 = new List<Production_Product>();
            Purchasing_ProductVendor = new List<Purchasing_ProductVendor>();
        }
    }
}
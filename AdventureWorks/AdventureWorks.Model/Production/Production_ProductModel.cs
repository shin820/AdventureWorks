using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Production
{
    public class Production_ProductModel
    {
        public int ProductModelId { get; set; } // ProductModelID (Primary key)
        public string Name { get; set; } // Name
        public string CatalogDescription { get; set; } // CatalogDescription
        public string Instructions { get; set; } // Instructions
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_Product> Production_Product { get; set; } // Product.FK_Product_ProductModel_ProductModelID;
        public virtual ICollection<Production_ProductModelIllustration> Production_ProductModelIllustration { get; set; } // ProductModelIllustration.FK_ProductModelIllustration_ProductModel_ProductModelID;
        public virtual ICollection<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCulture { get; set; } // ProductModelProductDescriptionCulture.FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID;

        public Production_ProductModel()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Production_Product = new List<Production_Product>();
            Production_ProductModelIllustration = new List<Production_ProductModelIllustration>();
            Production_ProductModelProductDescriptionCulture = new List<Production_ProductModelProductDescriptionCulture>();
        }
    }
}
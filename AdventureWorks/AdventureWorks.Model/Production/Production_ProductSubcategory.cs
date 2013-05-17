using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Production
{
    public class Production_ProductSubcategory
    {
        public int ProductSubcategoryId { get; set; } // ProductSubcategoryID (Primary key)
        public int ProductCategoryId { get; set; } // ProductCategoryID
        public string Name { get; set; } // Name
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_Product> Production_Product { get; set; } // Product.FK_Product_ProductSubcategory_ProductSubcategoryID;

        // Foreign keys
        public virtual Production_ProductCategory Production_ProductCategory { get; set; } //  ProductCategoryId - FK_ProductSubcategory_ProductCategory_ProductCategoryID

        public Production_ProductSubcategory()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Production_Product = new List<Production_Product>();
        }
    }
}
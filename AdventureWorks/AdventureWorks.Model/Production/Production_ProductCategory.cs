using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Production
{
    public class Production_ProductCategory
    {
        public int ProductCategoryId { get; set; } // ProductCategoryID (Primary key)
        public string Name { get; set; } // Name
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_ProductSubcategory> Production_ProductSubcategory { get; set; } // ProductSubcategory.FK_ProductSubcategory_ProductCategory_ProductCategoryID;

        public Production_ProductCategory()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Production_ProductSubcategory = new List<Production_ProductSubcategory>();
        }
    }
}
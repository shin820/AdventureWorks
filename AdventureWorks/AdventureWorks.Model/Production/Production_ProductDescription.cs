using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Production
{
    public class Production_ProductDescription
    {
        public int ProductDescriptionId { get; set; } // ProductDescriptionID (Primary key)
        public string Description { get; set; } // Description
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCulture { get; set; } // ProductModelProductDescriptionCulture.FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID;

        public Production_ProductDescription()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Production_ProductModelProductDescriptionCulture = new List<Production_ProductModelProductDescriptionCulture>();
        }
    }
}
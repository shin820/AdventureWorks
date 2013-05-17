using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Production
{
    public class Production_Culture
    {
        public string CultureId { get; set; } // CultureID (Primary key)
        public string Name { get; set; } // Name
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCulture { get; set; } // ProductModelProductDescriptionCulture.FK_ProductModelProductDescriptionCulture_Culture_CultureID;

        public Production_Culture()
        {
            ModifiedDate = DateTime.Now;
            Production_ProductModelProductDescriptionCulture = new List<Production_ProductModelProductDescriptionCulture>();
        }
    }
}
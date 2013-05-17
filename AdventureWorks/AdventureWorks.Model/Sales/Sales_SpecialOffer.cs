using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Sales
{
    public class Sales_SpecialOffer
    {
        public int SpecialOfferId { get; set; } // SpecialOfferID (Primary key)
        public string Description { get; set; } // Description
        public decimal DiscountPct { get; set; } // DiscountPct
        public string Type { get; set; } // Type
        public string Category { get; set; } // Category
        public DateTime StartDate { get; set; } // StartDate
        public DateTime EndDate { get; set; } // EndDate
        public int MinQty { get; set; } // MinQty
        public int? MaxQty { get; set; } // MaxQty
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Sales_SpecialOfferProduct> Sales_SpecialOfferProduct { get; set; } // SpecialOfferProduct.FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID;

        public Sales_SpecialOffer()
        {
            DiscountPct = 0.00m;
            MinQty = 0;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_SpecialOfferProduct = new List<Sales_SpecialOfferProduct>();
        }
    }
}
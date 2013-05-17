using System;
using AdventureWorks.Model.Production;

namespace AdventureWorks.Model.Sales
{
    public class Sales_SpecialOfferProduct
    {
        public int SpecialOfferId { get; set; } // SpecialOfferID (Primary key)
        public int ProductId { get; set; } // ProductID (Primary key)
        public Guid Rowguid { get; set; } // rowguid
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Sales_SpecialOffer Sales_SpecialOffer { get; set; } //  SpecialOfferId - FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID
        public virtual Production_Product Production_Product { get; set; } //  ProductId - FK_SpecialOfferProduct_Product_ProductID

        public Sales_SpecialOfferProduct()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}
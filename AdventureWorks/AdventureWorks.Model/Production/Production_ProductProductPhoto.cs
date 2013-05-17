using System;

namespace AdventureWorks.Model.Production
{
    public class Production_ProductProductPhoto
    {
        public int ProductId { get; set; } // ProductID (Primary key)
        public int ProductPhotoId { get; set; } // ProductPhotoID (Primary key)
        public bool Primary { get; set; } // Primary
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } //  ProductId - FK_ProductProductPhoto_Product_ProductID
        public virtual Production_ProductPhoto Production_ProductPhoto { get; set; } //  ProductPhotoId - FK_ProductProductPhoto_ProductPhoto_ProductPhotoID

        public Production_ProductProductPhoto()
        {
            Primary = false;
            ModifiedDate = DateTime.Now;
        }
    }
}
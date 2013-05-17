using System;

namespace AdventureWorks.Model.Production
{
    public class Production_ProductModelProductDescriptionCulture
    {
        public int ProductModelId { get; set; } // ProductModelID (Primary key)
        public int ProductDescriptionId { get; set; } // ProductDescriptionID (Primary key)
        public string CultureId { get; set; } // CultureID (Primary key)
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_ProductModel Production_ProductModel { get; set; } //  ProductModelId - FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID
        public virtual Production_ProductDescription Production_ProductDescription { get; set; } //  ProductDescriptionId - FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID
        public virtual Production_Culture Production_Culture { get; set; } //  CultureId - FK_ProductModelProductDescriptionCulture_Culture_CultureID

        public Production_ProductModelProductDescriptionCulture()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
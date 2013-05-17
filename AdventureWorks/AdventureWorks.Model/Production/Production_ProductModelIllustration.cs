using System;

namespace AdventureWorks.Model.Production
{
    public class Production_ProductModelIllustration
    {
        public int ProductModelId { get; set; } // ProductModelID (Primary key)
        public int IllustrationId { get; set; } // IllustrationID (Primary key)
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_ProductModel Production_ProductModel { get; set; } //  ProductModelId - FK_ProductModelIllustration_ProductModel_ProductModelID
        public virtual Production_Illustration Production_Illustration { get; set; } //  IllustrationId - FK_ProductModelIllustration_Illustration_IllustrationID

        public Production_ProductModelIllustration()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
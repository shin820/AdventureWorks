using System;

namespace AdventureWorks.Model.Production
{
    public class Production_ProductReview
    {
        public int ProductReviewId { get; set; } // ProductReviewID (Primary key)
        public int ProductId { get; set; } // ProductID
        public string ReviewerName { get; set; } // ReviewerName
        public DateTime ReviewDate { get; set; } // ReviewDate
        public string EmailAddress { get; set; } // EmailAddress
        public int Rating { get; set; } // Rating
        public string Comments { get; set; } // Comments
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } //  ProductId - FK_ProductReview_Product_ProductID

        public Production_ProductReview()
        {
            ReviewDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }
}
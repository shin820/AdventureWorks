using System;

namespace AdventureWorks.Model.Production
{
    public class Production_ProductDocument
    {
        public int ProductId { get; set; } // ProductID (Primary key)
        public int DocumentId { get; set; } // DocumentID (Primary key)
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } //  ProductId - FK_ProductDocument_Product_ProductID
        public virtual Production_Document Production_Document { get; set; } //  DocumentId - FK_ProductDocument_Document_DocumentID

        public Production_ProductDocument()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
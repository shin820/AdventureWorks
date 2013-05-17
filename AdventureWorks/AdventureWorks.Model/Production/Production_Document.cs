using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Production
{
    public class Production_Document
    {
        public int DocumentId { get; set; } // DocumentID (Primary key)
        public string Title { get; set; } // Title
        public string FileName { get; set; } // FileName
        public string FileExtension { get; set; } // FileExtension
        public string Revision { get; set; } // Revision
        public int ChangeNumber { get; set; } // ChangeNumber
        public byte Status { get; set; } // Status
        public string DocumentSummary { get; set; } // DocumentSummary
        public string Document { get; set; } // Document
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_ProductDocument> Production_ProductDocument { get; set; } // ProductDocument.FK_ProductDocument_Document_DocumentID;

        public Production_Document()
        {
            ChangeNumber = 0;
            ModifiedDate = DateTime.Now;
            Production_ProductDocument = new List<Production_ProductDocument>();
        }
    }
}
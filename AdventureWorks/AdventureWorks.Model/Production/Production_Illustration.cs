using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Production
{
    public class Production_Illustration
    {
        public int IllustrationId { get; set; } // IllustrationID (Primary key)
        public string Diagram { get; set; } // Diagram
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_ProductModelIllustration> Production_ProductModelIllustration { get; set; } // ProductModelIllustration.FK_ProductModelIllustration_Illustration_IllustrationID;

        public Production_Illustration()
        {
            ModifiedDate = DateTime.Now;
            Production_ProductModelIllustration = new List<Production_ProductModelIllustration>();
        }
    }
}
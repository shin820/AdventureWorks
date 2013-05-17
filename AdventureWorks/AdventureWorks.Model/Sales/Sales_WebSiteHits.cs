using System;

namespace AdventureWorks.Model.Sales
{
    public class Sales_WebSiteHits
    {
        public long WebSiteHitId { get; set; } // WebSiteHitID (Primary key)
        public string WebSitePage { get; set; } // WebSitePage
        public DateTime HitDate { get; set; } // HitDate (Primary key)
    }
}
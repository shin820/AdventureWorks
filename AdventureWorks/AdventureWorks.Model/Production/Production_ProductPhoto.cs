using System;
using System.Collections.Generic;

namespace AdventureWorks.Model.Production
{
    public class Production_ProductPhoto
    {
        public int ProductPhotoId { get; set; } // ProductPhotoID (Primary key)
        public string ThumbNailPhoto { get; set; } // ThumbNailPhoto
        public string ThumbnailPhotoFileName { get; set; } // ThumbnailPhotoFileName
        public string LargePhoto { get; set; } // LargePhoto
        public string LargePhotoFileName { get; set; } // LargePhotoFileName
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_ProductProductPhoto> Production_ProductProductPhoto { get; set; } // ProductProductPhoto.FK_ProductProductPhoto_ProductPhoto_ProductPhotoID;

        public Production_ProductPhoto()
        {
            ModifiedDate = DateTime.Now;
            Production_ProductProductPhoto = new List<Production_ProductProductPhoto>();
        }
    }
}
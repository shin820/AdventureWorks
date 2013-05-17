using System;

namespace AdventureWorks.Model
{
    public class AwBuildVersion
    {
        public byte SystemInformationId { get; set; } // SystemInformationID (Primary key)
        public string DatabaseVersion { get; set; } // Database Version
        public DateTime VersionDate { get; set; } // VersionDate
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        public AwBuildVersion()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
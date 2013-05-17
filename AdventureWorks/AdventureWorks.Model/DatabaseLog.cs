using System;

namespace AdventureWorks.Model
{
    public class DatabaseLog
    {
        public int DatabaseLogId { get; set; } // DatabaseLogID (Primary key)
        public DateTime PostTime { get; set; } // PostTime
        public string DatabaseUser { get; set; } // DatabaseUser
        public string Event { get; set; } // Event
        public string Schema { get; set; } // Schema
        public string Object { get; set; } // Object
        public string Tsql { get; set; } // TSQL
        public string XmlEvent { get; set; } // XmlEvent
    }
}
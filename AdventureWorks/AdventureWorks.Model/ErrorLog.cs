using System;

namespace AdventureWorks.Model
{
    public class ErrorLog
    {
        public int ErrorLogId { get; set; } // ErrorLogID (Primary key)
        public DateTime ErrorTime { get; set; } // ErrorTime
        public string UserName { get; set; } // UserName
        public int ErrorNumber { get; set; } // ErrorNumber
        public int? ErrorSeverity { get; set; } // ErrorSeverity
        public int? ErrorState { get; set; } // ErrorState
        public string ErrorProcedure { get; set; } // ErrorProcedure
        public int? ErrorLine { get; set; } // ErrorLine
        public string ErrorMessage { get; set; } // ErrorMessage

        public ErrorLog()
        {
            ErrorTime = DateTime.Now;
        }
    }
}
using System;

namespace AdventureWorks.Infrastructure
{
    public interface ILogger
    {
        void Error(object message);
        void Error(object message, Exception exception);
        void Fatal(object message);
        void Fatal(object message, Exception exception);
        void Debug(object message);
        void Debug(object message, Exception exception);
        void Info(object message);
        void Info(object message, Exception exception);
        void Warn(object message);
        void Warn(object message, Exception exception);
        void TimeIt(object message);
        void DebugFormat(string pattern, params object[] pArg0);
        void InfoFormat(string pattern, params object[] pArg0);
        void WarnFormat(string pattern, params object[] pArg0);
        void ErrorFormat(string pattern, params object[] pArg0);
        void FatalFormat(string pattern, params object[] pArg0);
    }
}
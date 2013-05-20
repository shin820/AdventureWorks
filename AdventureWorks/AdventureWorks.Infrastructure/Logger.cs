using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Infrastructure
{
    public class Logger
    {
        private readonly log4net.ILog _log;
        private const string DEFAULT_LOG_CONFIG_FILE = "configuration\\log4net.config";
        private const string DEFAULT_LOG_NAME = "Default";

        public Logger()
            : this(null, null)
        {
        }

        public Logger(string logName)
            : this(logName, null)
        {
        }

        public Logger(string logName, string configFilePath)
        {
            if (string.IsNullOrEmpty(configFilePath)) configFilePath = GetLogConfigFilePath();

            if (!string.IsNullOrEmpty(configFilePath) && File.Exists(configFilePath))
            {
                log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(configFilePath));
            }

            if (string.IsNullOrEmpty(logName)) logName = GetDefaultLogName();
            _log = log4net.LogManager.GetLogger(logName);
        }

        private static string GetLogConfigFilePath()
        {
            string configFilePath = ConfigurationManager.AppSettings["LogConfigFile"];
            if (string.IsNullOrEmpty(configFilePath))
            {
                configFilePath = Path.Combine(GetRootFolder(), DEFAULT_LOG_CONFIG_FILE);
            }
            else
            {
                string fullConfigFilePath =
                    Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configFilePath));
                if (!File.Exists(fullConfigFilePath)) configFilePath = GetRootFolder() + configFilePath;
                else return fullConfigFilePath;
            }

            return configFilePath;
        }

        private static string GetDefaultLogName()
        {
            string defaultLogName = ConfigurationManager.AppSettings["DefaultLogName"];
            if (string.IsNullOrEmpty(defaultLogName)) defaultLogName = DEFAULT_LOG_NAME;
            return defaultLogName;
        }

        public static Logger Instance
        {
            get
            {
                return SingletonProvider<Logger>.Instance;
            }
        }

        public bool NeedLog
        {
            get
            {
                return _log.IsErrorEnabled;
            }
        }

        #region Log methods

        public void Error(object message)
        {
            if (_log.IsErrorEnabled) _log.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            if (_log.IsErrorEnabled) _log.Error(message, exception);
        }

        public void Fatal(object message)
        {
            if (_log.IsFatalEnabled) _log.Fatal(message);
        }

        public void Fatal(object message, Exception exception)
        {
            if (_log.IsFatalEnabled) _log.Fatal(message, exception);
        }

        public void Debug(object message)
        {
            if (_log.IsDebugEnabled) _log.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            if (_log.IsDebugEnabled) _log.Debug(message, exception);
        }

        public void Info(object message)
        {
            if (_log.IsInfoEnabled) _log.Info(message);
        }

        public void Info(object message, Exception exception)
        {
            if (_log.IsInfoEnabled) _log.Info(message, exception);
        }

        public void Warn(object message)
        {
            if (_log.IsWarnEnabled) _log.Warn(message);
        }

        public void Warn(object message, Exception exception)
        {
            if (_log.IsWarnEnabled) _log.Warn(message, exception);
        }

        public void TimeIt(object message)
        {
            Debug("TIMER: " + message);
        }


        #endregion

        #region Log format methods

        public void DebugFormat(string pattern, params object[] pArg0)
        {
            if (_log.IsDebugEnabled) _log.DebugFormat(pattern, pArg0);
        }

        public void InfoFormat(string pattern, params object[] pArg0)
        {
            if (_log.IsInfoEnabled) _log.InfoFormat(pattern, pArg0);
        }

        public void WarnFormat(string pattern, params object[] pArg0)
        {
            if (_log.IsWarnEnabled) _log.WarnFormat(pattern, pArg0);
        }

        public void ErrorFormat(string pattern, params object[] pArg0)
        {
            if (_log.IsErrorEnabled) _log.ErrorFormat(pattern, pArg0);
        }

        public void FatalFormat(string pattern, params object[] pArg0)
        {
            if (_log.IsFatalEnabled) _log.FatalFormat(pattern, pArg0);
        }

        #endregion

        private static string GetRootFolder()
        {
            var di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            string rootFolder = di.FullName;

            if (di.Parent != null && di.Parent.Name.Equals("bin", StringComparison.OrdinalIgnoreCase))
            {
                if (di.Parent.Parent != null)
                {
                    rootFolder = di.Parent.Parent.FullName;
                }
            }
            else if (di.Name.Equals("bin", StringComparison.OrdinalIgnoreCase))
            {
                if (di.Parent != null)
                {
                    rootFolder = di.Parent.FullName;
                }
            }

            if (!rootFolder.EndsWith("\\"))
            {
                rootFolder += "\\";
            }

            return rootFolder;
        }
    }
}

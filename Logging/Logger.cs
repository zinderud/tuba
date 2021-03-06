﻿// muratONUR murat ONUR karadeniz
// Tuba Logging  Logger.cs
// 201312214:52 PM
// 201312214:52 PM
using System;
using System.Configuration;
using System.Globalization;
using log4net;

namespace Logging
{
    public class Logger : ILogger
    {
        #region Datamembers

        private static ILog log = null;
        private const string Log4netConnectionString = "Log4netConnectionString";

        #endregion

        #region Class Initializer

        public Logger()
        {
            log = LogManager.GetLogger(typeof(Logger));
            log4net.GlobalContext.Properties["host"] = Environment.MachineName;
        }

        #endregion

        #region ILogger Members

        public void EnterMethod(string methodName)
        {
            if (log.IsInfoEnabled)
                log.Info(string.Format(CultureInfo.InvariantCulture, "Entering Method {0}", methodName));
        }

        public void LeaveMethod(string methodName)
        {
            if (log.IsInfoEnabled)
                log.Info(string.Format(CultureInfo.InvariantCulture, "Leaving Method {0}", methodName));
        }

        public void LogException(Exception exception)
        {
            if (log.IsErrorEnabled)
                log.Error(string.Format(CultureInfo.InvariantCulture, "{0}", exception.Message), exception);
        }

        public void LogError(string message)
        {
            if (log.IsErrorEnabled)
                log.Error(string.Format(CultureInfo.InvariantCulture, "{0}", message));
        }

        public void LogWarningMessage(string message)
        {
            if (log.IsWarnEnabled)
                log.Warn(string.Format(CultureInfo.InvariantCulture, "{0}", message));
        }

        public void LogInfoMessage(string message)
        {
            if (log.IsInfoEnabled)
                log.Info(string.Format(CultureInfo.InvariantCulture, "{0}", message));
        }

        #endregion
    }

}
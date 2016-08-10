﻿// muratONUR murat ONUR karadeniz
// Tuba Logging  Logging.cs
// 201312212:04 PM
// 201312212:04 PM
//loglama 
using System;

namespace Logging
{
    public interface ILogger
    {
        /// <summary>
        /// Writes a log entry when entering the method.
        /// </summary>
        /// <param name="methodName">Name of the method.</param>
        void EnterMethod(string methodName);

        /// <summary>
        /// Writes a log entry when leaving the method.
        /// </summary>
        /// <param name="methodName">Name of the method.</param>
        void LeaveMethod(string methodName);

        /// <summary>
        /// Logs the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        void LogException(Exception exception);

        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="message">The message.</param>
        void LogError(string message);

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="message">The message.</param>
        void LogWarningMessage(string message);

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="message">The message.</param>
        void LogInfoMessage(string message);
    }
}

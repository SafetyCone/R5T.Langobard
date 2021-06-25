using System;

using Microsoft.Extensions.Logging;


namespace System
{
    public static partial class ILoggerExtensions
    {
        #region Synchronous, Action

        public static void Log(this ILogger logger, Action action, string preLogStatement, string postLogStatement)
        {
            logger.LogPreDebugPostInformation(action, preLogStatement, postLogStatement);
        }

        #endregion
    }
}

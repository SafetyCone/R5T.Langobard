using System;

using Microsoft.Extensions.Logging;


namespace System
{
    public static partial class ILoggerExtensions
    {
        #region Synchronous, Action

        public static void LogPreDebugPostInformation(this ILogger logger, Action action,
            Func<string> preLogStatementGenerator,
            Func<string> postLogStatementGenerator)
        {
            logger.Log(action,
                LogLevel.Debug, preLogStatementGenerator,
                LogLevel.Information, postLogStatementGenerator);
        }

        public static void LogPreDebugPostInformation(this ILogger logger, Action action,
            string preLogStatement,
            string postLogStatement)
        {
            logger.Log(action,
                LogLevel.Debug, preLogStatement,
                LogLevel.Information, postLogStatement);
        }

        #endregion
    }
}

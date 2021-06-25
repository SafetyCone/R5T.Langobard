using System;

using Microsoft.Extensions.Logging;


namespace System
{
    public static partial class ILoggerExtensions
    {
        #region Synchronous, Action

        public static void Log(this ILogger logger, Action action,
            LogLevel preLogLevel, Func<string> preLogStatementGenerator,
            LogLevel postLogLevel, Func<string> postLogStatementGenerator)
        {
            if (logger.IsEnabled(preLogLevel))
            {
                var preLogStatement = preLogStatementGenerator();

                logger.Log(preLogLevel, preLogStatement);
            }

            action();

            if (logger.IsEnabled(postLogLevel))
            {
                var postLogStatement = postLogStatementGenerator();

                logger.Log(postLogLevel, postLogStatement);
            }
        }

        public static void Log(this ILogger logger, Action action,
            LogLevel preLogLevel, string preLogStatement,
            LogLevel postLogLevel, string postLogStatement)
        {
            if (logger.IsEnabled(preLogLevel))
            {
                logger.Log(preLogLevel, preLogStatement);
            }

            action();

            if (logger.IsEnabled(postLogLevel))
            {
                logger.Log(postLogLevel, postLogStatement);
            }
        }

        #endregion
    }
}

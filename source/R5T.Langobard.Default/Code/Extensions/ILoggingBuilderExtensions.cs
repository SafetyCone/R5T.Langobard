using System;

using Microsoft.Extensions.Logging;


namespace System
{
    public static class ILoggingBuilderExtensions
    {
        /// <summary>
        /// Adds console logging with no console option changes.
        /// </summary>
        public static ILoggingBuilder AddDefaultLogging(this ILoggingBuilder loggingBuilder, LogLevel logLevel = LogLevelHelper.DefaultLogLevel)
        {
            loggingBuilder
                .AddConsole(consoleLoggerOptions =>
                {
                    // Do nothing.
                })
                .SetMinimumLevel(logLevel)
                ;

            return loggingBuilder;
        }
    }
}

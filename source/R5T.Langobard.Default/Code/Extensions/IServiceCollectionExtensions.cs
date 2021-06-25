using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.Dacia;


namespace System
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDefaultLogging(this IServiceCollection services, LogLevel logLevel = LogLevelHelper.DefaultLogLevel)
        {
            services
                .AddLogging(loggingBuilder =>
                {
                    loggingBuilder.AddDefaultLogging(logLevel);
                })
                ;

            return services;
        }

        public static IServiceAction<ILogger> AddDefaultLoggingAction(this IServiceCollection services, LogLevel logLevel = LogLevelHelper.DefaultLogLevel)
        {
            var serviceAction = ServiceAction.New<ILogger>(() => services.AddDefaultLogging(
                logLevel));

            return serviceAction;
        }
    }
}

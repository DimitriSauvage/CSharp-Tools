﻿using Microsoft.Extensions.Logging;

namespace DimitriSauvageTools.Logging
{
    public static class ApplicationLogging
    {
        /// <summary>
        /// Get the logger factory
        /// </summary>
        public static ILoggerFactory LoggerFactory { get; } = new LoggerFactory();
        /// <summary>
        /// Function to create a new logger
        /// </summary>
        /// <typeparam name="T">Type of logger</typeparam>
        /// <returns></returns>
        public static ILogger CreateLogger<T>() =>
          LoggerFactory.CreateLogger<T>();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ARDefBuilderDataManager
{
    public static class Logger
    {
        public static LogLevel LogLevel { get; set; } = LogLevel.Error;

        private static void LogWith(LogLevel level, string message)
        {
            if(LogLevel <= level)
            {
                Console.WriteLine($"[{level}]: {message}");
            }
        }

        public static void Error(string message) => LogWith(LogLevel.Error, message);
        public static void Warning(string message) => LogWith(LogLevel.Warning, message);
        public static void Info(string message) => LogWith(LogLevel.Info, message);
    }

    public enum LogLevel
    {
        Error,
        Warning,
        Info,
        None
    }
}

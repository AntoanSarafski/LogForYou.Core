using LogForU.Core.Appenders;
using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.Loggers;
using LogForU.Core.Loggers.Interfaces;
using System;

namespace LogForU.ConsoleApp
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IAppender appender = new ConsoleAppender(ReportLevel.Error);

            ILogger logger = new Logger(appender);

            logger.Info("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond");
        }
    }
}

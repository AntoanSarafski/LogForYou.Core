﻿using LogForU.Core.Appenders;
using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.Loggers;
using LogForU.Core.Loggers.Interfaces;
using LogForU.Core.Utils;
using System;

namespace LogForU.ConsoleApp
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IAppender appender = new ConsoleAppender();

            ILogger logger = new Logger(appender);

            DateTimeValidator.AddFormat("MM-dd-yyyy h:mm:ss tt");
            DateTimeValidator.AddFormat("MM.dd.yyyy h:mm:ss tt");

            logger.Info("03.31.2015 5:23:54 PM", "Everything seems fine");
        }
    }
}

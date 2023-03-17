﻿using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.Loggers.Interfaces;
using LogForU.Core.Models;
using LogForU.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.Loggers
{
    public class Logger : ILogger
    {

        private readonly ICollection<IAppender> appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public void Info(string dateTime, string text)
            => AppendAll(dateTime, text, ReportLevel.Info);

        public void Warning(string dateTime, string text)
            => AppendAll(dateTime, text, ReportLevel.Warning);

        public void Error(string dateTime, string text)
            => AppendAll(dateTime, text, ReportLevel.Error);

        public void Critical(string dateTime, string text)
            => AppendAll(dateTime, text, ReportLevel.Critical);

        public void Fatal(string dateTime, string text)
            => AppendAll(dateTime, text, ReportLevel.Fatal);

        private void AppendAll(string dateTime, string text, ReportLevel reportLevel) // TODO Report Level.
        {
            IMessage message = new Message(dateTime, text, reportLevel);

            foreach (IAppender appender in appenders)
            {
                if (message.reportLevel >= appender.ReportLevel)
                {
                    appender.AppendMessage(message);
                }
            }
        }

    }
}

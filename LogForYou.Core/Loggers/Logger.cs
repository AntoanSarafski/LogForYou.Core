using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Loggers.Interfaces;
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

        public void Info(string dateTime, string message)
        {
            throw new NotImplementedException();
        }
        public void Warning(string dateTime, string message)
        {
            throw new NotImplementedException();
        }

        public void Error(string dateTime, string message)
        {
            throw new NotImplementedException();
        }

        public void Critical(string dateTime, string message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string dateTime, string message)
        {
            throw new NotImplementedException();
        }

        private void AppendAll(string dateTime, string message) // TODO Report Level.
        {

        }

    }
}

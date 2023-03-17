using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ReportLevel reportLevel = ReportLevel.Info)
        {
            ReportLevel = reportLevel;
        }
        public ReportLevel ReportLevel { get; set; }

        public void AppendMessage(IMessage message)
        {
            Console.WriteLine(message.CreatedTime);
            Console.WriteLine(message.ReportLevel);
            Console.WriteLine(message.Text);
        }
    }
}

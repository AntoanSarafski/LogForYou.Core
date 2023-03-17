
using LogForU.Core.Enums;
using LogForU.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.Appenders.Interfaces
{
    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        void AppendMessage(IMessage message);
    }
}

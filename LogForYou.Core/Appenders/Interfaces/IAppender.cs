
using LogForU.Core.Enums;
using LogForU.Core.Layouts.Interfaces;
using LogForU.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.Appenders.Interfaces
{
    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        public ILayout Layout { get; }

        public int MessagesCount { get; }

        void AppendMessage(IMessage message);


    }
}

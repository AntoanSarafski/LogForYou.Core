using LogForU.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.Models.Interfaces
{
    public interface IMessage
    {
        public string CreatedTime { get; }

        public string Text { get; }

        public ReportLevel reportLevel { get; }
    }
}

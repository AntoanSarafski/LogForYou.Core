using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.Layouts.Interfaces;
using LogForU.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.Appenders
{
    public class FileAppender : IAppender
    {
        //TODO ADD LOG FILE 
        public FileAppender(ILayout layout, ReportLevel reportLevel = ReportLevel.Info)
        {

        }
        public ILayout Layout => throw new NotImplementedException();

        public ReportLevel ReportLevel { get ; set ; }


        public void AppendMessage(IMessage message)
        {

        }
    }
}

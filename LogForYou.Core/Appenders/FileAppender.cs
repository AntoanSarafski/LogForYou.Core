﻿using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.IO.Interfaces;
using LogForU.Core.Layouts.Interfaces;
using LogForU.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LogForU.Core.Appenders
{
    public class FileAppender : IAppender
    {
        //TODO ADD LOG FILE 
        public FileAppender(ILayout layout,ILogFile logFile, ReportLevel reportLevel = ReportLevel.Info)
        {
            Layout = layout;
            LogFile = logFile;
            ReportLevel = reportLevel;
        }
        public ILayout Layout { get; private set; }

        public ILogFile LogFile { get; private set; }


        public ReportLevel ReportLevel { get ; set; }

        public int MessagesCount { get; private set; }

        public void AppendMessage(IMessage message)
        {
            string content = string.Format(Layout.Format, message.CreatedTime, message.ReportLevel, message.Text);

            LogFile.WriteLine(content);
            File.AppendAllText(LogFile.FullPath, content + Environment.NewLine); //The path must come from LogFile file directory.Thats just for testing

            MessagesCount++;
        }
    }
}

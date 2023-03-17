﻿using LogForU.Core.Enums;
using LogForU.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.Models
{
    public class Message : IMessage
    {

        //TODO VALIDATE MESSAGE !

        public Message(string createdTime, string text, ReportLevel reportLevel)
        {
            CreatedTime = createdTime;
            Text = text;
            ReportLevel = reportLevel;
        }
        public string CreatedTime { get; private set; }

        public string Text { get; private set; }

        public ReportLevel ReportLevel { get; private set; }
    }
}
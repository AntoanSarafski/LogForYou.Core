using LogForU.Core.Enums;
using LogForU.Core.Exceptions;
using LogForU.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.Models
{
    public class Message : IMessage
    {
        private string createdTime;
        private string text;
        private string createdTime1;

        public Message(string createdTime, string text, ReportLevel reportLevel)
        {
            CreatedTime = createdTime;
            Text = text;
            ReportLevel = reportLevel;
        }
        public string CreatedTime 
        {
            get => createdTime;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new EmptyCreatedTimeException();
                }
                createdTime = value;
            }

        }

        public string Text
        {
            get => text;
            private set
            {
                text = value;
            }


        }

        public ReportLevel ReportLevel { get; private set; }
    }
}

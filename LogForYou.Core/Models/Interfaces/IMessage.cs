using LogForU.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.Models.Interfaces
{
    public interface IMessage
    {
        public string CreatedTime { get; }    // "3/26/2015 2:08:11 PM", 

        public string Text { get; }
                                                // INFO     - "User Pesho successfully registered."
                                                // Warning  - "ping is too high - disconnect imminent" 
                                                // ERROR    - "Error parsing JSON."
                                                // Critical - "No connection string found in App.config"
                                                // Fatal    - "mscorlib.dll does not respond"

        public ReportLevel reportLevel { get; }
    }
}

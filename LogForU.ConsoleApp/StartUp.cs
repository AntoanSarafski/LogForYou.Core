using LogForU.ConsoleApp.CustomLayouts;
using LogForU.Core.Appenders;
using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.IO;
using LogForU.Core.Layouts;
using LogForU.Core.Layouts.Interfaces;
using LogForU.Core.Loggers;
using LogForU.Core.Loggers.Interfaces;
using LogForU.Core.Utils;
using System;
using System.IO;

namespace LogForU.ConsoleApp
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //var simpleLayout = new SimpleLayout();
            //var consoleAppender = new ConsoleAppender(simpleLayout);



            //var logger = new Logger(consoleAppender, fileAppender);
            //logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON."); 
            //logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");


            var xmlLayout = new XmlLayout();
            var consoleAppender = new ConsoleAppender(xmlLayout);

            var file = new LogFile("test", "xml", Directory.GetCurrentDirectory());
            var fileAppender = new FileAppender(xmlLayout, file);


            var logger = new Logger(consoleAppender, fileAppender);

            logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond");
            logger.Critical("3/31/2015 5:23:54 PM", "No connection string found in App.config");

        }
    }
}

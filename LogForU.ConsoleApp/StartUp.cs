using LogForU.Core.Loggers;
using LogForU.Core.Loggers.Interfaces;
using System;

namespace LogForU.ConsoleApp
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
        }
    }
}

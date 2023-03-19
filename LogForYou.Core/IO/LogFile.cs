using LogForU.Core.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.IO
{
    public class LogFile : ILogFile
    {
        public string Name
        {
            get;
            set;
        }

        public string Extenxion
        {
            get;
            set;
        }

        public string Path
        {
            get;
            set;
        }
        public string FullPath
        {
            get;
            set;
        }

        public string Content
        {
            get;
            set;
        }

        public int Size
        {
            get;
            set;
        }

        public void WriteLine(string text)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.IO.Interfaces
{
    public interface ILogFile
    {
        string Name { get; }

        string Extenxion { get; }

        string Path { get; }

        string Content { get; }

        int Size { get; }

        void WriteLine(string text);
    }
}

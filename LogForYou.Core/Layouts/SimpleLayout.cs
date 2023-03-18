using LogForU.Core.Layouts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.Layouts
{
    public class SimpleLayout : ILayout
    {
        private const string SimpleFormat = "{0} - {1} - {2}";
        public string Format => SimpleFormat;
    }
}

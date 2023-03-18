using LogForU.Core.Layouts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.Layouts
{
    public class SimpleLayout : ILayout
    {
        private const string simpleFormat = "{0} - {1} - {2}";
        public string Format => "";
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LogForU.Core.Utils
{
    public static class DateTimeValidator
    {
        public static bool ValidateDateTime(string createdTime)
        {
            string format = "M/dd/yyyy h:mm:ss tt";
            if (DateTime.TryParseExact(
                createdTime, 
                format, 
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, 
                out DateTime result))
            {
                return true;
            }
            return false;
        }
    }
}

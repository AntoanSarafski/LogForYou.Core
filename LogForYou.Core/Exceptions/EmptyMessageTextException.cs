using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.Exceptions
{
    public class EmptyMessageTextException : Exception
    {
        private const string DefaultMessage =
            "Message text cannot be null or whitespace";

        public EmptyMessageTextException()
            :base(DefaultMessage)
        {
        }

        public EmptyMessageTextException(string message)
            : base(message)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LogForU.Core.Exceptions
{
    public class EmptyFileExtensionException : Exception
    {
        private const string DefaultMessage =
            "File extension cannot be null or whitespace";

        public EmptyFileExtensionException()
            : base(DefaultMessage)
        {
        }

        public EmptyFileExtensionException(string message)
            : base(message)
        {

        }
    }
}

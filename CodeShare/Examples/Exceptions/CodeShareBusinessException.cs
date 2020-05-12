using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CodeShare.Examples.Exceptions
{
    public sealed class CodeShareBusinessException : CodeShareException
    {
        public CodeShareBusinessException()
        {
        }

        public CodeShareBusinessException(string message) : base(message)
        {
        }

        public CodeShareBusinessException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

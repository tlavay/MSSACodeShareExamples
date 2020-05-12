using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CodeShare.Examples.Exceptions
{
    public class CodeShareException : Exception
    {
        public CodeShareException()
        {
        }

        public CodeShareException(string message) : base(message)
        {
        }

        public CodeShareException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CodeShareException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

using System;
using System.Runtime.Serialization;

namespace Vynnyk02.Pages
{
    [Serializable]
    internal class InvalidEmailFormatException : Exception
    {
        public InvalidEmailFormatException()
        {
        }

        public InvalidEmailFormatException(string messsage) : base("Invalid Email")
        {
        }

        public InvalidEmailFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidEmailFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
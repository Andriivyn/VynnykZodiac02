using System;
using System.Runtime.Serialization;

namespace Vynnyk02.Pages
{
    [Serializable]
    internal class InvalidDateFormatException : Exception
    {
        public InvalidDateFormatException()
        {
        }

        public InvalidDateFormatException(string message) : base("Invalid date format")
        {
        }

        public InvalidDateFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidDateFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
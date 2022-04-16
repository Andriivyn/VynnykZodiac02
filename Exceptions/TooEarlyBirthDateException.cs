using System;
using System.Runtime.Serialization;

namespace Vynnyk02.Pages
{
    [Serializable]
    internal class TooEarlyBirthDateException : Exception
    {
        public TooEarlyBirthDateException()
        {
        }

        public TooEarlyBirthDateException(string message) : base(message)
        {
        }

        public TooEarlyBirthDateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TooEarlyBirthDateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
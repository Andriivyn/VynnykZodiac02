using System;
using System.Runtime.Serialization;

namespace Vynnyk02.Pages
{
    [Serializable]
    internal class FutureBirthDateException : Exception
    {
        public FutureBirthDateException()
        {
        }

        public FutureBirthDateException(string message) : base("Please fill the correct date format")
        {
        }

        public FutureBirthDateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FutureBirthDateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
using System;
using System.Runtime.Serialization;

namespace Library1
{
    [Serializable]
    internal class NotValidateException : Exception
    {
        public NotValidateException()
        {
        }

        public NotValidateException(string message) : base(message)
        {
        }

        public NotValidateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotValidateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
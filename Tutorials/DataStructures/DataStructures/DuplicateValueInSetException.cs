using System;
using System.Runtime.Serialization;

namespace DataStructures
{
    [Serializable]
    internal class DuplicateValueInSetException : Exception
    {
        public DuplicateValueInSetException()
        {
        }

        public DuplicateValueInSetException(string message) : base(message)
        {
        }

        public DuplicateValueInSetException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicateValueInSetException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
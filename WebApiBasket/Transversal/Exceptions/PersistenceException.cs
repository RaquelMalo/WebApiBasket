using System;
using System.Runtime.Serialization;

namespace WebApiBasket.Transversal.Exceptions
{
    [Serializable]
    public class PersistenceException : Exception
    {
        public PersistenceException()
        {
        }

        public PersistenceException(string message) : base(message)
        {
        }

        public PersistenceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PersistenceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
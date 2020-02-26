using System;
using System.Runtime.Serialization;

namespace WebApiBasket.Transversal.Exceptions
{
    [Serializable]
    public class FactoryException : Exception
    {
       public FactoryException()
        {
        }

        public FactoryException(string message) : base(message)
        {
        }
        
        public FactoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FactoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
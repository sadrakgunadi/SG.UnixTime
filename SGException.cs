using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SG.UnixTime
{
    public class SGException : Exception
    {
        public SGException()
        {
        }

        public SGException(string message) : base(message)
        {
        }

        public SGException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SGException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

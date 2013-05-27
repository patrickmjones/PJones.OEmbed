using System;
using System.Runtime.Serialization;

namespace PJones.OEmbed.Exceptions
{
    [Serializable]
    class OEmbedException : Exception
    {
        public OEmbedException()
            : base() { }

        public OEmbedException(string message)
            : base(message) { }

        public OEmbedException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public OEmbedException(string message, Exception innerException)
            : base(message, innerException) { }

        public OEmbedException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected OEmbedException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}

using System;
using System.Runtime.Serialization;

namespace PJones.OEmbed.Exceptions
{
    [Serializable]
    class UnknownProviderException : OEmbedException
    {
        public UnknownProviderException()
            : base("Could not determine provider type") { }

        public UnknownProviderException(string message)
            : base(message) { }

        public UnknownProviderException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public UnknownProviderException(string message, Exception innerException)
            : base(message, innerException) { }

        public UnknownProviderException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected UnknownProviderException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }

    }
}

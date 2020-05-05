using OXR.Trading.Common.Enum;
using System;
using System.Runtime.Serialization;

namespace OXR.Trading.Common.Exceptions
{
    [Serializable]
    public class WebServiceException : TradingProcessingException
    {
        public WebServiceException()
        : base()
        {
        }

        public WebServiceException(ErrorCode code, string desc)
            : base(ErrorType.WebService, code, desc)
        {
        }

        public WebServiceException(ErrorCode code, string desc, Exception innerException)
            : base(ErrorType.WebService, code, desc, innerException)
        {
        }

        protected WebServiceException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}

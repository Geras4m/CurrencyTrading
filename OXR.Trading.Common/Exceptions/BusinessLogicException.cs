using System;
using OXR.Trading.Common.Enum;
using System.Runtime.Serialization;

namespace OXR.Trading.Common.Exceptions
{
    [Serializable]
    public class BusinessLogicException : TradingProcessingException
    {
        public BusinessLogicException()
        : base()
        {
        }

        public BusinessLogicException(ErrorCode code, string desc)
        : base(ErrorType.BusinessLogic, code, desc)
        {
        }

        public BusinessLogicException(ErrorCode code, string desc, Exception innerException)
        : base(ErrorType.BusinessLogic, code, desc, innerException)
        {
        }

        public BusinessLogicException(SerializationInfo info, StreamingContext context)
        : base(info, context)
        {
        }
    }
}

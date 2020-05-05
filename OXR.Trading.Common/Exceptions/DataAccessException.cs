using System;
using OXR.Trading.Common.Enum;
using System.Runtime.Serialization;

namespace OXR.Trading.Common.Exceptions
{
    [Serializable]
    public class DataAccessException : TradingProcessingException
    {
        public DataAccessException()
        : base()
        {
        }

        public DataAccessException(ErrorCode code, string desc)
        : base(ErrorType.DataAccess, code, desc)
        {
        }

        public DataAccessException(ErrorCode code, string desc, Exception innerException)
        : base(ErrorType.DataAccess, code, desc, innerException)
        {
        }

        public DataAccessException(SerializationInfo info, StreamingContext context)
        : base(info, context)
        {
        }
    }
}

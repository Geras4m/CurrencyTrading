using OXR.Trading.Common.Enum;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;

namespace OXR.Trading.Common.Exceptions
{
    [Serializable]
    public class TradingProcessingException : Exception
    {
        public ErrorCode Code { get; }
        public string Description { get; }
        public ErrorType Type { get; } = ErrorType.DataAccess;

        public TradingProcessingException()
        : base()
        {
        }

        public TradingProcessingException(ErrorType type, ErrorCode code, string desc)
            : base(string.Format($"{type}Exception. Code: {code}; Description: {desc}"))
        {
            Type = type;
            Code = code;
            Description = desc;
        }

        public TradingProcessingException(ErrorType type, ErrorCode code, string desc, Exception innerException)
        : base(desc, innerException)
        {
            Type = type;
            Code = code;
            Description = desc;
        }

        protected TradingProcessingException(SerializationInfo info, StreamingContext context)
        : base(info, context)
        {
            Code = (ErrorCode)info.GetInt32("code");
            Description = info.GetString("desc");
            Type = (ErrorType)info.GetInt32("type");
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("code", Code);
            info.AddValue("desc", Description);
            info.AddValue("type", Type);
        }
    }
}

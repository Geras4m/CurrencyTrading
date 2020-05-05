using Newtonsoft.Json;

namespace OXR.Trading.Common.Exceptions.Handling
{
    public class ResponseError
    {
        [JsonProperty("errorCode")]
        public int ErrorCode { get; set; }

        [JsonProperty("errorType")]
        public string ErrorType { get; set; }

        [JsonProperty("errorDescription")]
        public string ErrorDescription { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OXR.Trading.WebApi.Models
{
    public class ResponseTest
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

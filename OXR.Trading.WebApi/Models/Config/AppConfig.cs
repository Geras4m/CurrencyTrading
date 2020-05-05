using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OXR.Trading.WebApi.Models.Config
{
    public class AppConfig
    {
        [JsonProperty("ApiVersion")]
        public string ApiVersion { get; set; }

        [JsonProperty("TotalEnrichmentPercent")]
        public decimal TotalEnrichmentPercent { get; set; }
    }
}

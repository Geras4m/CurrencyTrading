using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OXR.Trading.WebApi.Models.RequestModels
{
    public class TradeModel
    {
        [JsonProperty("sellingCurrency")]
        public string SellingCurrency { get; set; }

        [JsonProperty("buyingCurrency")]
        public string BuyingCurrency { get; set; }

        [JsonProperty("soldAmount")]
        public decimal SoldAmount { get; set; }

        [JsonProperty("clientName")]
        public string ClientName { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OXR.Trading.Core.Dto
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

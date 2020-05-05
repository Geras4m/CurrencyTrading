using Newtonsoft.Json;
using System;

namespace OXR.Trading.WebApi.Models
{
    public class TradeResponse : BaseModel
    {
        [JsonProperty("sellingCurrency")]
        public string SellingCurrency { get; set; }

        [JsonProperty("buyingCurrency")]
        public string BuyingCurrency { get; set; }

        [JsonProperty("soldAmount")]
        public decimal SoldAmount { get; set; }

        [JsonProperty("purchasedAmount")]
        public decimal PurchasedAmount { get; set; }

        [JsonProperty("brokerRate")]
        public decimal BrokerRate { get; set; }

        [JsonProperty("profitInBuyingCurrency")]
        public decimal ProfitInBuyingCurrency { get; set; }

        [JsonProperty("profitInGBP")]
        public decimal ProfitInGBP { get; set; }

        [JsonProperty("clientName")]
        public string ClientName { get; set; }
        [JsonProperty("dealDate")]
        public DateTime DealDate { get; set; }
    }
}
using OXR.Trading.Common.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace OXR.Trading.Core.Dto
{
    public class TradeDto : BaseDto
    {
        public Currency SellingCurrency { get; set; }
        public Currency BuyingCurrency { get; set; }
        public decimal SoldAmount { get; set; }
        public decimal PurchasedAmount { get; set; }
        public decimal BrokerRate { get; set; }
        public decimal ProfitInBuyingCurrency { get; set; }
        public decimal ProfitInGBP { get; set; }
        public string ClientName { get; set; }
        public DateTime DealDate { get; set; }
    }
}

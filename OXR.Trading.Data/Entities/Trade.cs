﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OXR.Trading.Data.Entities
{
    public class Trade : Entity
    {
        public int SellingCurrency { get; set; }
        public int BuyingCurrency { get; set; }
        public decimal SoldAmount { get; set; }
        public decimal PurchasedAmount { get; set; }
        public decimal BrokerRate { get; set; }
        public decimal ProfitInBuyingCurrency { get; set; }
        public decimal ProfitInGBP { get; set; }
        public string ClientName { get; set; }
        public DateTime DealDate { get; set; }
    }
}

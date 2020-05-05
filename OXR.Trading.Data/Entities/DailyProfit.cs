using System;
using System.Collections.Generic;
using System.Text;

namespace OXR.Trading.Data.Entities
{
    public class DailyProfit : Entity
    { 
        public decimal ProfitInGBP { get; set; }
        public DateTime DealDay { get; set; }
    }
}

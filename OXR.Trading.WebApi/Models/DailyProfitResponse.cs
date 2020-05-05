using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OXR.Trading.WebApi.Models
{
    public class DailyProfitResponse : BaseModel
    {
        public decimal ProfitInGBP { get; set; }
        public DateTime DealDay { get; set; }
    }
}

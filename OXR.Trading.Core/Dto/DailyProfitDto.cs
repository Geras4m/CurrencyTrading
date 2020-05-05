using System;
using System.Collections.Generic;
using System.Text;

namespace OXR.Trading.Core.Dto
{
    public class DailyProfitDto : BaseDto
    {
        public decimal ProfitInGBP { get; set; }
        public DateTime DealDay { get; set; }
    }
}

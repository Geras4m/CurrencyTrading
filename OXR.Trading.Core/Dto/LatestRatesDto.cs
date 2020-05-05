using System;
using System.Collections.Generic;
using System.Text;

namespace OXR.Trading.Core.Dto
{
    public class LatestRatesDto
    {
        public string Disclaimer { get; set; }
        public Uri License { get; set; }
        public long Timestamp { get; set; }
        public string Base { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }
    }
}

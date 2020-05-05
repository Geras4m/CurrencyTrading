using OXR.Trading.Common.Enum;
using OXR.Trading.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OXR.Trading.Core.Services.Interfaces
{
    public interface IRateService
    {
        LatestRatesDto GetLatestRates();
        decimal GetBrokerRate(LatestRatesDto latestRates, Currency currency);
    }
}

using OXR.Trading.ApiFramework.Services.Interfaces;
using System;
using OXR.Trading.ApiFramework.Models;

namespace OXR.Trading.ApiFramework.Services
{
    public class LatestRatesService : ILatestRatesService
    {
        protected readonly IOXRatesClient _client;
        public LatestRatesService(IOXRatesClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public LatestRates Get()
            => _client.GetLatestRates().Data;        
    }
}

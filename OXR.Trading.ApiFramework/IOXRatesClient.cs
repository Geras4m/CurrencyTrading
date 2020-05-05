using OXR.Trading.ApiFramework.Models;

namespace OXR.Trading.ApiFramework
{
    public interface IOXRatesClient
    {
        IOXRatesResponse<LatestRates> GetLatestRates();
    }
}

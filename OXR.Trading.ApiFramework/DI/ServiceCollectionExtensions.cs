using OXR.Trading.ApiFramework.Services;
using OXR.Trading.ApiFramework.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace OXR.Trading.ApiFramework.DI
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApiFrameworkServices(this IServiceCollection services)
        {
            services.AddScoped<IOXRatesClient, OXRatesClient>();
            services.AddScoped<ILatestRatesService, LatestRatesService>();
        }
    }
}

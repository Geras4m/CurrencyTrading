using OXR.Trading.Core.Services;
using OXR.Trading.Core.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace OXR.Trading.Core.DI
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessLogicServices(this IServiceCollection services)
        {
            services.AddScoped<ITradeService, TradeService>();
            services.AddScoped<IProfitService, ProfitService>();
            services.AddScoped<IRateService, RateService>();
        }
    }
}

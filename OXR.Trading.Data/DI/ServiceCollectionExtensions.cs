using OXR.Trading.Data.Repositories;
using OXR.Trading.Data.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace OXR.Trading.Data.DI
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<ITradeRepository, TradeRepository>();
            services.AddScoped<IProfitRepository, ProfitRepository>();
        }
    }
}

using OXR.Trading.Common.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace OXR.Trading.Common.DI
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMapperServices(this IServiceCollection services)
        {
            services.AddScoped<IMyMapper, MyMapper>();
        }
    }
}

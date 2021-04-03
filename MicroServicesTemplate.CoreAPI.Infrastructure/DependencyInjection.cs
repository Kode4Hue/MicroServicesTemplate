using MicroServicesTemplate.CoreAPI.Infrastructure.Features.Petrol.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MicroServicesTemplate.CoreAPI.Application.Features.Petrol.Services;

namespace MicroServicesTemplate.CoreAPI.Infrastructure
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddTransient<IIdentityService, IdentityService>();
            services.AddTransient<IPetrolService, PetrolService>();
            return services;
        }
    }
}

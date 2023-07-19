using PlanarSystemWS.src.Application.AddressManagement;
using PlanarSystemWS.src.Application.CustomerManagement;
using PlanarSystemWS.src.Application.SolarEnergyManagement;
using PlanarSystemWS.src.Application.UserManagement;
using PlanarSystemWS.src.Infra.Adapters.AddressManagement;
using PlanarSystemWS.src.Infra.Adapters.CustomerManagement;
using PlanarSystemWS.src.Infra.Adapters.SolarEnergyManagement;
using PlanarSystemWS.src.Infra.Adapters.UserManagement;

namespace PlanarSystemWS.src.Infra
{
    public static class AdaptersExtensions
    {
        public static IServiceCollection AddAdapters(this IServiceCollection services)
        {
            services.AddScoped<IAddressAdapter, AddressAdapter>();
            services.AddScoped<ICustomerAdapter, CustomerAdapter>();
            services.AddScoped<ISolarEnergyAdapter, SolarEnergyAdapter>();
            services.AddScoped<IUserAdapter, UserAdapter>();

            return services;
        }
    }
}

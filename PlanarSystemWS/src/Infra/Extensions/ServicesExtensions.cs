using PlanarSystemWS.src.Application.AddressManagement;
using PlanarSystemWS.src.Application.CustomerManagement;
using PlanarSystemWS.src.Application.SolarEnergyManagement;
using PlanarSystemWS.src.Application.UserManagement;
using PlanarSystemWS.src.Domain.AddressManagement;
using PlanarSystemWS.src.Domain.CustomerManagement;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Infra
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ISolarEnergyService, SolarEnergyService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}

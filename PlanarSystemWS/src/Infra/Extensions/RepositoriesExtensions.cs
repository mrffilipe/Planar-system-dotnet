using PlanarSystemWS.src.Domain.AddressManagement;
using PlanarSystemWS.src.Domain.CustomerManagement;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;
using PlanarSystemWS.src.Domain.UserManagement;
using PlanarSystemWS.src.Infra.Repositories.AddressManagement;
using PlanarSystemWS.src.Infra.Repositories.CustomerManagement;
using PlanarSystemWS.src.Infra.Repositories.SolarEnergyManagement;
using PlanarSystemWS.src.Infra.Repositories.UserManagement;

namespace PlanarSystemWS.src.Infra
{
    public static class RepositoriesExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ISolarEnergyRepository, SolarEnergyRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}

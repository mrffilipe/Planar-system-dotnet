using PlanarSystemWS.src.Application.AddressManagement;
using PlanarSystemWS.src.Application.CustomerManagement;
using PlanarSystemWS.src.Application.SalesManagement;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Application.SolarEnergyManagement;

public class BudgetFormRegistrationDTO
{
    public BudgetForm BudgetForm { get; private set; }
    public ICollection<ConsumerUnitRegistrationDTO> ConsumerUnits { get; private set; }
    public SellerRegistrationDTO Seller { get; private set; }
    public CustomerRegistrationDTO Customer { get; private set; }
    public AddressRegistrationDTO InstallationAddress { get; private set; }
}

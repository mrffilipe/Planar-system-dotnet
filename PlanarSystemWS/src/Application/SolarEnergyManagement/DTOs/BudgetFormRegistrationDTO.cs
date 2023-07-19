using PlanarSystemWS.src.Application.AddressManagement;
using PlanarSystemWS.src.Application.CustomerManagement;
using PlanarSystemWS.src.Application.SalesManagement;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Application.SolarEnergyManagement;

public class BudgetFormRegistrationDTO
{
    public BudgetForm BudgetForm { get; set; }
    public ICollection<ConsumerUnitRegistrationDTO> ConsumerUnits { get; set; }
    //public SellerRegistrationDTO Seller { get; set; }
    public CustomerRegistrationDTO Customer { get; set; }
    public AddressRegistrationDTO InstallationAddress { get; set; }
}

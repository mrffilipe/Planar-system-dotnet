using PlanarSystemWS.src.Application.AddressManagement;
using PlanarSystemWS.src.Application.CustomerManagement;
using PlanarSystemWS.src.Application.SalesManagement;
using PlanarSystemWS.src.Application.Shared;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Application.SolarEnergyManagement;

public class ReplyBudgetFormDTO : IEntityDTO
{
    public Guid Id { get; private set; }
    public BudgetForm BudgetForm { get; private set; }
    public ICollection<ReplyConsumerUnitDTO> ConsumerUnits { get; private set; }
    public ReplySellerDTO Seller { get; private set; }
    public ReplyCustomerDTO Customer { get; private set; }
    public ReplyAddressDTO InstallationAddress { get; private set; }
    public DateTime CreatedOn { get; private set; }

    public DateTime UpdatedOn { get; private set; }
}

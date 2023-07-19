using PlanarSystemWS.src.Application.AddressManagement;
using PlanarSystemWS.src.Application.CustomerManagement;
using PlanarSystemWS.src.Application.SalesManagement;
using PlanarSystemWS.src.Application.Shared;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Application.SolarEnergyManagement;

public class ReplyBudgetFormDTO : IEntityDTO
{
    public Guid Id { get; set; }
    public BudgetForm BudgetForm { get; set; }
    public ICollection<ReplyConsumerUnitDTO> ConsumerUnits { get; set; }
    public ReplySellerDTO Seller { get; set; }
    public ReplyCustomerDTO Customer { get; set; }
    public ReplyAddressDTO InstallationAddress { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}
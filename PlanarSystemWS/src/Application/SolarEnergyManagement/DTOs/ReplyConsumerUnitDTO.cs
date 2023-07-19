using PlanarSystemWS.src.Application.Shared;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Application.SolarEnergyManagement;

public class ReplyConsumerUnitDTO : IEntityDTO
{
    public Guid Id => throw new NotImplementedException();
    public string Reference { get; private set; }
    public NetworkType NetworkType { get; private set; }
    public double MonthlyConsumption { get; private set; }
    public double UnitPrice { get; private set; }
    public ReplyBudgetFormDTO BudgetForm { get; private set; }
    public DateTime CreatedOn => throw new NotImplementedException();
    public DateTime UpdatedOn => throw new NotImplementedException();
}

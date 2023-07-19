using PlanarSystemWS.src.Application.Shared;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Application.SolarEnergyManagement;

public class DetailedReplyConsumerUnitDTO : IEntityDTO
{
    public Guid Id { get; set; }
    public string Reference { get; set; }
    public NetworkType NetworkType { get; set; }
    public double MonthlyConsumption { get; set; }
    public double UnitPrice { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}

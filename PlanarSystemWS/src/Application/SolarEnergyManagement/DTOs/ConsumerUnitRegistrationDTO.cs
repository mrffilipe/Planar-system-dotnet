using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Application.SolarEnergyManagement;

public class ConsumerUnitRegistrationDTO
{
    public string Reference { get; set; }
    public NetworkType NetworkType { get; set; }
    public double MonthlyConsumption { get; set; }
    public double UnitPrice { get; set; }
}

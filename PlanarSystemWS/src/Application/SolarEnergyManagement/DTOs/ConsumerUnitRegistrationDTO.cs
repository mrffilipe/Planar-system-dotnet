using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Application.SolarEnergyManagement;

public class ConsumerUnitRegistrationDTO
{
    public string Reference { get; private set; }
    public NetworkType NetworkType { get; private set; }
    public double MonthlyConsumption { get; private set; }
    public double UnitPrice { get; private set; }
    public BudgetFormRegistrationDTO BudgetForm { get; private set; }
}

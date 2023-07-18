using PlanarSystemWS.src.Domain.Shared;

namespace PlanarSystemWS.src.Domain.SolarEnergyManagement;

public class ConsumerUnit : BaseEntity
{
    public string Reference { get; private set; }
    public NetworkType NetworkType { get; private set; }
    public double MonthlyConsumption { get; private set; }
    public double UnitPrice { get; private set; }
    public Guid BudgetFormId { get; private set; }
    public RefBudgetForm BudgetForm { get; private set; }

    public ConsumerUnit()
    {
    }

    public ConsumerUnit(
        string reference,
        NetworkType networkType,
        double monthlyConsumption,
        double unitPrice
        )
    {
        Reference = reference;
        NetworkType = networkType;
        MonthlyConsumption = monthlyConsumption;
        UnitPrice = unitPrice;
    }
}
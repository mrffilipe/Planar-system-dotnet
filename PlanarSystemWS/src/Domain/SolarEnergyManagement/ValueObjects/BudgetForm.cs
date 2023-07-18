namespace PlanarSystemWS.src.Domain.SolarEnergyManagement;

public class BudgetForm
{
    public double ExtraProduction { get; set; }
    public string Observation { get; set; }
    public double Transformer { get; set; }
}

//public readonly record struct BudgetForm(
//        double ExtraProduction,
//        string Observation,
//        double Transformer
//    );

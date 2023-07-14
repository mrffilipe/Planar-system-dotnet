namespace PlanarSystemWS.src.Domain.SolarEnergyManagement;

public readonly record struct BudgetForm(
        double ExtraProduction,
        string Observation,
        double Transformer
    );

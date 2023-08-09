using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public record MinimumConsumerUnitResponseDTO(
    string Reference,
    NetworkType NetworkType,
    double MonthlyConsumption,
    double UnitPrice
    );
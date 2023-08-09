using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public record RegisterConsumerUnitDTO(
    string Reference,
    NetworkType NetworkType,
    double MonthlyConsumption,
    double UnitPrice
    );
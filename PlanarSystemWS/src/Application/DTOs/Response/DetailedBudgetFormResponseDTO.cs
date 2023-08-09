using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public record DetailedBudgetFormResponseDTO(
    Guid Id,
    BudgetForm BudgetForm,
    ICollection<MinimumConsumerUnitResponseDTO> ConsumerUnits,
    MinimumCustomerResponseDTO Customer,
    MinimumAddressResponseDTO InstallationAddress,
    DateTime CreatedOn,
    DateTime UpdatedOn
    ) : IEntityDTO;
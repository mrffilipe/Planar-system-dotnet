using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public record RegisterBudgetFormDTO(
    BudgetForm BudgetForm,
    ICollection<RegisterConsumerUnitDTO> ConsumerUnits,
    RegisterCustomerDTO Customer,
    RegisterAddressDTO InstallationAddress
    );
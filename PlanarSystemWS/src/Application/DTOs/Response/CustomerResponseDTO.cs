namespace PlanarSalesWS.src.Application;

public record CustomerResponseDTO(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    DateTime CreatedOn,
    DateTime UpdatedOn
    ) : IEntityDTO;
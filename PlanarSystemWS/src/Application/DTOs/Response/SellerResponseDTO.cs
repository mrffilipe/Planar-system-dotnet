namespace PlanarSalesWS.src.Application;

public record SellerResponseDTO(
    Guid Id,
    string FirstName,
    string LastName,
    double SalesCommission,
    DateTime CreatedOn,
    DateTime UpdatedOn
    ) : IEntityDTO;
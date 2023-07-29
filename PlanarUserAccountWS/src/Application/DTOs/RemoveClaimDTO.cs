using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Application;

public record RemoveClaimDTO(
    Guid Id,
    UserClaim UserClaim
    );
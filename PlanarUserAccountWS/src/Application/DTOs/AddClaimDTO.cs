using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Application;

public record AddClaimDTO(
    UserClaim UserClaim,
    Guid UserId
    );
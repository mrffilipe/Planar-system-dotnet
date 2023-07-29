using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Application;

public record UpdateClaimDTO(
    Guid Id,
    UserClaim UserClaim,
    Guid Userid
    );
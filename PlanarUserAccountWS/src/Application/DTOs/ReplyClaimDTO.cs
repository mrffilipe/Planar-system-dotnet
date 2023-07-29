using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Application;

public record ReplyClaimDTO(
    Guid Id,
    UserClaim UserClaim,
    DateTime CreatedOn,
    DateTime UpdatedOn
    );
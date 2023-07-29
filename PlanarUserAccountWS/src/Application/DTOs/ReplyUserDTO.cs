namespace PlanarUserAccountWS.src.Application;

public record ReplyUserDTO(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    ICollection<ReplyClaimDTO> Claims,
    DateTime CreatedOn,
    DateTime UpdatedOn
    );
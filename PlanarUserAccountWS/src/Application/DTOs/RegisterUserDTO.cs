namespace PlanarUserAccountWS.src.Application;

public record RegisterUserDTO(
    string FirstName,
    string LastName,
    string Email,
    ICollection<AddMinimumClaimDTO> Claims
    );
namespace PlanarUserAccountWS.src.Application;

public record UpdateUserDTO(
    Guid Id,
    string FirstName,
    string LastName,
    string Email
    );
namespace PlanarAuthenticationWS.src.Application;

public record RegisterUserDTO(
    string UserAccountId,
    string UserName,
    string Email
    );
namespace PlanarAuthenticationWS.src.Application;

public record SignInUserDTO(
    string UserName,
    string Password,
    bool IsPersistent
    );
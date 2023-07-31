namespace PlanarAuthenticationWS.src.Application;

public record SignInUser(
    string UserName,
    string Password,
    bool IsPersistent,
    bool LockoutOnFailure
    );
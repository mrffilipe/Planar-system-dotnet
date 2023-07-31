namespace PlanarAuthenticationWS.src.Application;

public record SignInUserResult(
    string UserName,
    string Token
    );
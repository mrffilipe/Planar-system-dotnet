namespace PlanarAuthenticationWS.src.Application;

public record SignInUserResultDTO(
    string UserName,
    string Token
    );
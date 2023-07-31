using Microsoft.AspNetCore.Identity;

namespace PlanarAuthenticationWS.src.Application;

public record SignInUserResultDTO(
    string UserName,
    bool IsPersistent,
    SignInResult SignInResult,
    string Token
    );
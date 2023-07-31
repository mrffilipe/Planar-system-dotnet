using Microsoft.AspNetCore.Identity;

namespace PlanarAuthenticationWS.src.Application;

public record SignInUserResult(
    string UserName,
    bool IsPersistent,
    SignInResult SignInResult,
    string Token
    );
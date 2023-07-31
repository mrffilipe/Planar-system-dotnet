using Microsoft.AspNetCore.Identity;
using PlanarAuthenticationWS.src.Application;

namespace PlanarAuthenticationWS.src.Domain;

public interface IAuthenticationService
{
    Task<IdentityResult> RegisterUser(User user);
    Task<SignInUserResult> SignIn(SignInUser user);
}
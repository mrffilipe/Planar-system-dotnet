using Microsoft.AspNetCore.Identity;

namespace PlanarAuthenticationWS.src.Domain;

public interface IAuthenticationService
{
    Task<IdentityResult> RegisterUser(User user);
}
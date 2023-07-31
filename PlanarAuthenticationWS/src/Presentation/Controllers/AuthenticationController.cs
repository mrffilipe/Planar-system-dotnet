using Microsoft.AspNetCore.Mvc;
using PlanarAuthenticationWS.src.Application;
using PlanarAuthenticationWS.src.Infra.Controllers;

namespace AuthenticationController.src.Presentation.Controllers;

public class AuthenticationController : BaseController
{
    private readonly IAuthenticationAdapter _authenticationAdapter;

    public AuthenticationController(IAuthenticationAdapter authenticationAdapter)
    {
        _authenticationAdapter = authenticationAdapter;
    }

    [HttpPost]
    [Route("sign-in")]
    public async Task<SignInUserResultDTO> SignIn([FromBody] SignInUserDTO user)
    {
        try
        {
            var result = await _authenticationAdapter.SignIn(user);

            return result;
        }
        catch (Exception ex) { throw; }
    }
}
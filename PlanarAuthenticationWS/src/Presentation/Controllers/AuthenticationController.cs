using Microsoft.AspNetCore.Mvc;
using PlanarAuthenticationWS.src.Application;
using PlanarAuthenticationWS.src.Infra.Controllers;

namespace AuthenticationController.src.Presentation.Controllers;

public class ActivityController : BaseController
{
    private readonly IAuthenticationAdapter _authenticationAdapter;

    public ActivityController(IAuthenticationAdapter authenticationAdapter)
    {
        _authenticationAdapter = authenticationAdapter;
    }

    [HttpPost]
    [Route("sign-in")]
    public async Task SignIn()
    {
        try
        {

        }
        catch (Exception ex) { throw; }
    }
}
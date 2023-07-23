using Microsoft.AspNetCore.Mvc;
using PlanarSystemWS.src.Presentation.Shared.Controllers;

namespace PlanarSystemWS.src.Presentation.ApplicationManagement.Controllers;

public class HealthController : BaseController
{
    [HttpGet]
    public IActionResult Check()
    {
        var obj = new { };

        return Ok(obj);
    }
}
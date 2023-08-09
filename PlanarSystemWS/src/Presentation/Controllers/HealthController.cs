using Microsoft.AspNetCore.Mvc;

namespace PlanarSalesWS.src.Presentation;

public class HealthController : BaseController
{
    [HttpGet]
    public async Task<ActionResult> Check()
    {
        var obj = new { };

        return Ok(obj);
    }
}
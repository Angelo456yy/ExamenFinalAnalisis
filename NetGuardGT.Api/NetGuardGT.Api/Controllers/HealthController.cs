using Microsoft.AspNetCore.Mvc;

namespace NetGuardGT.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            estado = "API funcionando",
            servicio = "NetGuard GT"
        });
    }
}

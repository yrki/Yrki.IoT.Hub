using Microsoft.AspNetCore.Mvc;
using Yrki.IoT.Contracts;

namespace Yrki.IoT.Hub.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GatewayDataController : ControllerBase
{
    private readonly ILogger<GatewayDataController> _logger;

    public GatewayDataController(ILogger<GatewayDataController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "PostGatewaydata")]
    public async Task<IActionResult> PostGatewayData([FromBody] Message message)
    {
        return Ok();
        // Receive data from gateway every X minutes.
    }
}

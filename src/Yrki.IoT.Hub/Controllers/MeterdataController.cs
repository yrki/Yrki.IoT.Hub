using Microsoft.AspNetCore.Mvc;
using Yrki.IoT.Contracts;

namespace Yrki.IoT.Hub.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MeterdataController : ControllerBase
{
    private readonly ILogger<MeterdataController> _logger;

    public MeterdataController(ILogger<MeterdataController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "WMBusMessage")]
    public async Task Post([FromBody] WMBusMessage message)
    {
        _logger.LogTrace(System.Text.Json.JsonSerializer.Serialize(message));
        // Send message to Queue.
    }
}
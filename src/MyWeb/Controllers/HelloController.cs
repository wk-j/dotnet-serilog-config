using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers;

[ApiController]
[Route("api/hello")]
public class HelloController : ControllerBase {
    [HttpGet("hi")]
    public ActionResult Hi(string name, [FromServices] ILogger<HelloController> logger) {
        logger.LogInformation("Say hi to {name}", name);
        logger.LogTrace("Say hi to {name}", name);
        logger.LogDebug("Say hi to {name}", name);

        return Ok($"Hi {name}");
    }
}
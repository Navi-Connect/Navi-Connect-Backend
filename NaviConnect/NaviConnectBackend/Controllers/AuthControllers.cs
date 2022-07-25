using Microsoft.AspNetCore.Mvc;

namespace NaviConnectBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IHostEnvironment _environment;
}
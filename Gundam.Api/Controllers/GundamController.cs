using Microsoft.AspNetCore.Mvc;
using Gundam.Core.Models;

namespace Gundam.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class GundamController : ControllerBase
{
    private readonly ILogger<GundamController> _logger;

    public GundamController(ILogger<GundamController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetGundam")]
    public MobileSuit Get()
    {
        return new MobileSuit()
        {
            GundamId = 0,
            Model = "RX-78-2",
            Pilot = "Amuro Ray"
        };
    }
}

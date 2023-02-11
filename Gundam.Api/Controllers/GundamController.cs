using Microsoft.AspNetCore.Mvc;
using Gundam.Core.Models;
using Gundam.Core.Interfaces;

namespace Gundam.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class GundamController : ControllerBase
{
    private readonly ILogger<GundamController> _logger;

    private readonly IRepository _repo;

    public GundamController(ILogger<GundamController> logger, IRepository repository)
    {
        _logger = logger;
        _repo = repository;
    }

    [HttpGet(Name = "GetGundam")]
    public IEnumerable<MobileSuit> Get()
    {
        return _repo.GetMobileSuits();
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Shop.WebAPI.Controllers.V1;

[ApiVersion("1.0")]
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
public partial class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{id}")]
    public IActionResult GetUser(int id)
    {
        return Ok(new
        {
            Name = "Username",
            LastName = "Last Name",
            Received = id
        });
    }

    [HttpGet]
    public IActionResult GetAllUsers()
    {
        return Ok(new List<dynamic>(){
            new
                {
                    Name = "Username",
                    LastName = "Last Name",
                    Received = 1
                },
        new
            {
                Name = "Username",
                LastName = "Last Name",
                Received = 2
            }
        });
    }
}
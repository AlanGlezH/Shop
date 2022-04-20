using Microsoft.AspNetCore.Mvc;

namespace ShopAPI.API.Controllers.v2.User;

[Tags("Users")]
[ApiVersion("2.0")]
[ApiController]
[Route("api/v{version:apiVersion}/users")]
public class UserGetAllController : ControllerBase
{
    private readonly ILogger<UserGetAllController> _logger;
    public UserGetAllController(ILogger<UserGetAllController> logger)
    {
        _logger = logger;
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
                LastName = "Last Name v2",
                Received = 2
            }
        });
    }
}
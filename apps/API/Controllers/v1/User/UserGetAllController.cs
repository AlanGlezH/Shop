using Microsoft.AspNetCore.Mvc;
using Shop.User.Application;
using Shop.User.Application.SearchAll;
using Shop.User.Domain;

namespace Shop.API.Controllers.v1.User;

[Tags("Users")]
[ApiVersion("1.0")]
[ApiController]
[Route("api/v{version:apiVersion}/users")]
public class UserGetAllController : ControllerBase
{
    private readonly ILogger<UserGetAllController> _logger;
    private readonly UserRepository _userRepository;
    public UserGetAllController(ILogger<UserGetAllController> logger, UserRepository userRepository)
    {
        _logger = logger;
        _userRepository = userRepository;

    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var searcher = new SearchAllUsersQueryHandler(new UserSearcher(_userRepository));
        var usersResponse = await searcher.Handle(new SearchAllUsersQuery());
        return Ok(usersResponse.Users);
    }
}
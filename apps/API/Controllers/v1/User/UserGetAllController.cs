using Microsoft.AspNetCore.Mvc;
using Shop.User.Application.SearchAll;
using MediatR;
using System.Diagnostics;

namespace Shop.API.Controllers.v1.User;

[Tags("Users")]
[ApiVersion("1.0")]
[ApiController]
[Route("api/v{version:apiVersion}/users")]
public class UserGetAllController : ControllerBase
{
    private readonly ILogger<UserGetAllController> _logger;
    private readonly IMediator _mediator;

    public UserGetAllController(ILogger<UserGetAllController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var usersResponse = await _mediator.Send(new SearchAllUsersQuery());
        return Ok(usersResponse.Users);
    }
}
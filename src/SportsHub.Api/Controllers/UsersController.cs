using Microsoft.AspNetCore.Mvc;
using SportsHub.Api.Services;

namespace SportsHub.Api.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IUsersService _usersService;

    public UsersController(IUsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAllUsers()
    {
        var result = await _usersService.GetAllUsers();
        return Ok(result);
    }

    [HttpGet("{userId}")]
    public async Task<IActionResult> GetUser(int userId)
    {
        var result = await _usersService.GetUser(userId);
        
        return result is null ? NotFound() : Ok(result);
    }
}

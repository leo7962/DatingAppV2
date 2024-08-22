using DatingAppV2.Server.Data;
using DatingAppV2.Server.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingAppV2.Server.Controllers;

public class UsersController(DataContext context) : BaseApiController
{
    [AllowAnonymous]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await context.Users.ToListAsync();
        return Ok(users);
    }

    [Authorize]
    [HttpGet("{id:int}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = await context.Users.FindAsync(id);

        if (user == null) return NotFound();

        return Ok(user);
    }
}
using DatingAppV2.Server.Data;
using DatingAppV2.Server.DTOs;
using DatingAppV2.Server.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace DatingAppV2.Server.Controllers;

public class AccountController(DataContext context, ITokenService tokenService) : BaseApiController
{
    private readonly DataContext _context = context;

    [HttpPost("register")] // account/register
    public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
    {
        if (await UserExists(registerDto.Username)) return BadRequest("Username is taken");
        using var hmac = new HMACSHA512();
        return Ok();

        //var user = new AppUser
        //{
        //    UserName = registerDto.Username.ToLower(),
        //    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
        //    PasswordSalt = hmac.Key
        //};

        //await _context.Users.AddAsync(user);
        //await _context.SaveChangesAsync();

        //return Ok(new UserDto { UserName = user.UserName, Token = tokenService.CreateToken(user) });
    }

    [HttpPost("login")]
    public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
    {
        var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == loginDto.UserName.ToLower());
        if (user == null) return Unauthorized("Invalid username");

        using var hmac = new HMACSHA512(user.PasswordSalt);

        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

        for (var i = 0; i < computedHash.Length; i++)
            if (computedHash[i] != user.PasswordHash[i])
                return Unauthorized("Invalid password");

        return Ok(new UserDto { UserName = user.UserName, Token = tokenService.CreateToken(user) });
    }

    private async Task<bool> UserExists(string username)
    {
        return await _context.Users.AnyAsync(x => x.UserName.ToLower() == username.ToLower());
    }
}
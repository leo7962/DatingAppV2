using DatingAppV2.Server.Entities;

namespace DatingAppV2.Server.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}
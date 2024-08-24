using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DatingAppV2.Server.Entities;

public class AppUser
{
    [Key] public int Id { get; set; }
    [Required] public required string UserName { get; set; }
    [PasswordPropertyText] public byte[] PasswordHash { get; set; } = [];
    [PasswordPropertyText] public byte[] PasswordSalt { get; set; } = [];
    public DateOnly DateOfBirth { get; set; }
    public required string KnownAs { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime LastActive { get; set; } = DateTime.UtcNow;
    public required string Gender { get; set; }
    public string? Introduction { get; set; }
    public string? Interests { get; set; }
    public string? LookingFor { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
    public List<Photo> Photos { get; set; } = [];

    //public int GetAge()
    //{
    //    return DateOfBirth.CalculateAge();
    //}
}
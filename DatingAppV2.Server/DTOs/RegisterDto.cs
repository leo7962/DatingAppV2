using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DatingAppV2.Server.DTOs;

public class RegisterDto
{
    [Required] [MaxLength(100)] public string Username { get; set; } = string.Empty;

    [Required]
    [PasswordPropertyText]
    [StringLength(8, MinimumLength = 4)]
    public string Password { get; set; } = string.Empty;
}
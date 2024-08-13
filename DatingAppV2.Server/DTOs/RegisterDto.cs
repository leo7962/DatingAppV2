using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DatingAppV2.Server.DTOs
{
    public class RegisterDto
    {
        [Required]
        [MaxLength(100)]
        public required string Username { get; set; }
        [Required]
        [PasswordPropertyText]
        public required string Password { get; set; }
    }
}

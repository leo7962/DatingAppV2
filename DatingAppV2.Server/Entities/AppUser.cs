using System.ComponentModel.DataAnnotations;

namespace DatingAppV2.Server.Entities
{
    public class AppUser
    {
        [Key] public int Id { get; set; }
        [Required] public required string UserName { get; set; }

    }
}

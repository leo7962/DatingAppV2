using DatingAppV2.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingAppV2.Server.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUser> Users { get; set; }
    }
}

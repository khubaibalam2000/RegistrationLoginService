using Microsoft.EntityFrameworkCore;
using RegistrationLoginService.Database.Models;

namespace RegistrationLoginService.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<User>? Users { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Jalgrattaeksam.Models;

namespace Jalgrattaeksam.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Eksam> Eksam { get; set; }
        public DbSet<User> User { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}

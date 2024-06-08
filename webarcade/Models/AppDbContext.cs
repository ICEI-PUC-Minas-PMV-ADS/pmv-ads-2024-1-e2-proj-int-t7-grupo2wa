using Microsoft.EntityFrameworkCore;

namespace webarcade.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Game> Games { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sugestao> Sugestoes { get; set; }
        public DbSet<Community> Communitys { get; set; }

    }
}

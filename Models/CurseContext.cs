using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class CurseContext : DbContext
    {
        public CurseContext(DbContextOptions<CurseContext> options) : base(options)
        {

        }

        public DbSet<Curse> Curses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CurseSeed());
        }
    }
}

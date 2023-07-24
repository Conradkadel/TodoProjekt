using Microsoft.EntityFrameworkCore;

namespace TodoProjekt.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

        public DbSet<EinzelAufgabe> EinzelAufgabe { get; set; }
        public DbSet<UnterAufgabe> UnterAufgabe { get; set; }
    }
}

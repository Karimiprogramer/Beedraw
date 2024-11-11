using Microsoft.EntityFrameworkCore;

namespace BeeDraw.Database.Contexts
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}

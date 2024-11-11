using BeeDraw.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace BeeDraw.Database.Contexts
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {

        public DbSet<UserTbl> UserTbl { get; set; }
        public DbSet<FriendshipTbl> FriendshipTbl { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTbl>().HasQueryFilter(u => !u.IsDeleted);

        }
    }
}

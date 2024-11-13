using BeeDraw.Database.Models;
using BeeDraw.Database.Models.Lottery;
using BeeDraw.Database.Models.User;
using BeeDraw.Database.Models.Wallet;
using Microsoft.EntityFrameworkCore;

namespace BeeDraw.Database.Contexts
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {

        public DbSet<UserTbl> UserTbl { get; set; }
        public DbSet<FriendshipTbl> FriendshipTbl { get; set; }
        public DbSet<TaskTbl> TaskTbl { get; set; }
        public DbSet<TaskCompletionTbl> CompletionTbl { get; set; }
        
        
        public DbSet<LotteryPrizeTbl> LotteryPrizeTbl { get; set; }
        public DbSet<LotteryTbl> LotteryTbl { get; set; }
        public DbSet<LotteryTicketTbl> LotteryTicketTbl { get; set; }

        
        public DbSet<CurrencyTbl> CurrencyTbl { get; set; }
        public DbSet<WalletBalanceTbl> WalletBalanceTbl { get; set; }
        public DbSet<WalletTbl> WalletTbl { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTbl>().HasQueryFilter(u => !u.IsDeleted);

        }
    }
}

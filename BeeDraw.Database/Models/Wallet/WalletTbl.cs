using BeeDraw.Database.Models.User;
using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models.Wallet;

public class WalletTbl:EntityBase
{
    public int UserId { get; set; } 
    public UserTbl? User { get; set; }
}
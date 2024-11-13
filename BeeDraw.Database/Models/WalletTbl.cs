using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models;

public class WalletTbl:EntityBase
{
    public int UserId { get; set; } 
    public UserTbl? User { get; set; }
}
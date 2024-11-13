using BeeDraw.Database.Models.User;
using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models.Lottery;

public class LotteryTicketTbl: EntityBase
{
    public bool IsWinner { get; set; }
    
    public int LotteryId { get; set; }  
    public LotteryTbl? Lottery { get; set; }

    public int UserId { get; set; }  
    public UserTbl? User { get; set; }

    public int TicketCount { get; set; } 
    public DateTime DatePurchased { get; set; }
}
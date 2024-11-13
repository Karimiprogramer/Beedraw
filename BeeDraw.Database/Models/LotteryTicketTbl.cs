using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models;

public class LotteryTicketTbl: EntityBase
{
    public int LotteryId { get; set; }  
    public LotteryTbl? Lottery { get; set; }

    public int UserId { get; set; }  
    public UserTbl? User { get; set; }

    public string TicketNumber { get; set; } 
    public DateTime DatePurchased { get; set; }
}
using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models;

public class LotteryTbl:EntityBase
{
    public required string Name { get; set; }  
    public DateTime StartDate { get; set; }  
    public DateTime EndDate { get; set; } 
    public bool IsActive { get; set; } 

    public ICollection<LotteryTicketTbl>? Tickets { get; set; }

    public ICollection<LotteryPrizeTbl>? Prizes { get; set; }
}
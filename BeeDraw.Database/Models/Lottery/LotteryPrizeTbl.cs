using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models.Lottery;

public class LotteryPrizeTbl: EntityBase
{
    public int LotteryId { get; set; }  
    public LotteryTbl? Lottery { get; set; }

    public required string PrizeName { get; set; } 
    public decimal PrizeAmount { get; set; }  
    public int NumberOfPrizes { get; set; } 
}
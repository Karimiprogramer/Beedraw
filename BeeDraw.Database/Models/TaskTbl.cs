using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models;

public class TaskTbl:EntityBase
{
    public required string Name { get; set; } 
    public required string Description { get; set; }  
    public decimal RewardAmount { get; set; }  
    public bool IsActive { get; set; } 
    public DateTime CreatedAt { get; set; }
    public DateTime? ExpirationDate { get; set; }
}
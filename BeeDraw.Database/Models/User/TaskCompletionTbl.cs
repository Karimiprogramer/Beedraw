using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models.User;

public class TaskCompletionTbl:EntityBase
{
    public int UserId { get; set; } 
    public UserTbl? User { get; set; }
    
    public int TaskId { get; set; }  
    public TaskTbl? Task { get; set; }
    
    public DateTime CompletedAt { get; set; }  
    public bool IsRewardClaimed { get; set; } 
}
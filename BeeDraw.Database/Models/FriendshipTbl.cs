using System.ComponentModel.DataAnnotations.Schema;
using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models;

public class FriendshipTbl:EntityBase
{
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public UserTbl? User { get; set; }

    public int FriendId { get; set; }
    [ForeignKey("FriendId")]
    public UserTbl? Friend { get; set; }
}
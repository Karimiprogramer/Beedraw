using System.ComponentModel.DataAnnotations.Schema;
using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models.User;

public class FriendshipTbl:EntityBase
{
    public int SenderId { get; set; }
    [ForeignKey("SenderId")]
    public UserTbl? User { get; set; }

    public int ReceiverId { get; set; }
    [ForeignKey("ReceiverId")]
    public UserTbl? Friend { get; set; }
}
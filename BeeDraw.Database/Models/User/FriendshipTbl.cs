using System.ComponentModel.DataAnnotations.Schema;
using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models.User;

public class FriendshipTbl : EntityBase
{
    public int SenderId { get; set; }

    [ForeignKey(nameof(SenderId))]
    [InverseProperty("SentFriendRequests")]
    public UserTbl Sender { get; set; } = null!;

    public int ReceiverId { get; set; }

    [ForeignKey(nameof(ReceiverId))]
    [InverseProperty("ReceivedFriendRequests")]
    public UserTbl Receiver { get; set; } = null!;
}

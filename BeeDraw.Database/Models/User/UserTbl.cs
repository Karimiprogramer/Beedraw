using System.ComponentModel.DataAnnotations;
using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models.User;

public class UserTbl:EntityBase
{
    [Required]
    public long TelegramUserId { get; set; }  
    
    [MaxLength(50)]
    public required string Username { get; set; }

    [MaxLength(100)]
    public required string FirstName { get; set; }

    [MaxLength(100)]
    public required string LastName { get; set; }

    [MaxLength(10)]
    public required string LanguageCode { get; set; }

    [MaxLength(20)]
    public required string PhoneNumber { get; set; }

    [MaxLength(Int32.MaxValue)]
    public string? WalletAddress { get; set; }

    public int RefererId { get; set; }

    
    public DateTime DateJoined { get; set; } = DateTime.UtcNow;

    public bool IsBlocked { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
    public bool IsBot { get; set; }

    
    public List<FriendshipTbl>? Friends { get; set; } = [];

}
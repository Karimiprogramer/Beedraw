using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models.User;

//Fixed By ChatGPT on 2024 12 06
public class UserTbl : EntityBase
{
    [Required]
    public long TelegramUserId { get; set; }  
    
    [Required]
    [MaxLength(50)]
    public string Username { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [MaxLength(10)]
    public string LanguageCode { get; set; } = string.Empty;

    [Required]
    [MaxLength(20)]
    public string PhoneNumber { get; set; } = string.Empty;

    [MaxLength(255)]  // Set a reasonable limit for WalletAddress
    public string? WalletAddress { get; set; }

    public long RefererId { get; set; }  // Changed to long for consistency

    public DateTime DateJoined { get; set; } = DateTime.UtcNow;

    public bool IsBlocked { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
    public bool IsBot { get; set; }

    [InverseProperty("Sender")]
    public List<FriendshipTbl> SentFriendRequests { get; set; } = new();

    [InverseProperty("Receiver")]
    public List<FriendshipTbl> ReceivedFriendRequests { get; set; } = new();  // Added this property
}

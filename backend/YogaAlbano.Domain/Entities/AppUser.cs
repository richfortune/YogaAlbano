using YogaAlbano.Domain.Enums;

namespace YogaAlbano.Domain.Entities;

public class AppUser
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly? DateOfBirth { get; set; }
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public bool PrivacyAccepted { get; set; }
    public UserStatus Status { get; set; } = UserStatus.PendingEmailConfirmation;
    public UserRole Role { get; set; } = UserRole.User;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? EmailConfirmedAt { get; set; }
    public DateTime? ApprovedAt { get; set; }
    public DateTime? DisabledAt { get; set; }
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
    public ICollection<UserSubscription> Subscriptions { get; set; } = new List<UserSubscription>();
}

using YogaAlbano.Domain.Enums;

namespace YogaAlbano.Domain.Entities;

public class UserSubscription
{
    public Guid Id { get; set; }
    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    public Guid SubscriptionPlanId { get; set; }
    public SubscriptionPlan? SubscriptionPlan { get; set; }
    public SubscriptionStatus Status { get; set; } = SubscriptionStatus.Active;
    public int? TotalCredits { get; set; }
    public int? RemainingCredits { get; set; }
    public DateTime StartsAt { get; set; }
    public DateTime ExpiresAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? CancelledAt { get; set; }
}

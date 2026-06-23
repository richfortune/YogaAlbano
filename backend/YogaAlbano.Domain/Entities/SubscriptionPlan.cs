using YogaAlbano.Domain.Enums;

namespace YogaAlbano.Domain.Entities;

public class SubscriptionPlan
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public SubscriptionType Type { get; set; }
    public decimal Price { get; set; }
    public int? TotalCredits { get; set; }
    public int? DurationInDays { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

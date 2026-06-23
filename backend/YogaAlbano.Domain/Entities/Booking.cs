using YogaAlbano.Domain.Enums;

namespace YogaAlbano.Domain.Entities;

public class Booking
{
    public Guid Id { get; set; }
    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    public Guid YogaClassId { get; set; }
    public YogaClass? YogaClass { get; set; }
    public BookingStatus Status { get; set; } = BookingStatus.Confirmed;
    public DateTime BookedAt { get; set; } = DateTime.UtcNow;
    public DateTime? CancelledAt { get; set; }
    public DateTime? PromotedFromWaitingListAt { get; set; }
}

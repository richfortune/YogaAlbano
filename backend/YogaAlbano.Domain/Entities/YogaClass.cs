namespace YogaAlbano.Domain.Entities;

public class YogaClass
{
    public Guid Id { get; set; }
    public Guid CourseId { get; set; }
    public Course? Course { get; set; }
    public Guid TeacherId { get; set; }
    public Teacher? Teacher { get; set; }
    public Guid? RecurringClassScheduleId { get; set; }
    public RecurringClassSchedule? RecurringClassSchedule { get; set; }
    public DateTime StartAt { get; set; }
    public DateTime EndAt { get; set; }
    public int MaxParticipants { get; set; }
    public bool IsCancelled { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}

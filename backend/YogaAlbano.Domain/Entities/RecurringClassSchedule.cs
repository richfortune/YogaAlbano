namespace YogaAlbano.Domain.Entities;

public class RecurringClassSchedule
{
    public Guid Id { get; set; }
    public Guid CourseId { get; set; }
    public Course? Course { get; set; }
    public Guid TeacherId { get; set; }
    public Teacher? Teacher { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public int MaxParticipants { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<YogaClass> GeneratedClasses { get; set; } = new List<YogaClass>();
}

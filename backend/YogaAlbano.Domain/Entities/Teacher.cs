namespace YogaAlbano.Domain.Entities;

public class Teacher
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Bio { get; set; }
    public string? PhotoUrl { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<RecurringClassSchedule> RecurringSchedules { get; set; } = new List<RecurringClassSchedule>();
    public ICollection<YogaClass> Classes { get; set; } = new List<YogaClass>();
}

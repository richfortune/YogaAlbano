using YogaAlbano.Domain.Enums;

namespace YogaAlbano.Domain.Entities;

public class Course
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public ClassLevel Level { get; set; } = ClassLevel.AllLevels;
    public string? ImageUrl { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<RecurringClassSchedule> RecurringSchedules { get; set; } = new List<RecurringClassSchedule>();
    public ICollection<YogaClass> Classes { get; set; } = new List<YogaClass>();
}

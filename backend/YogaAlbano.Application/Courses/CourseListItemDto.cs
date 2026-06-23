namespace YogaAlbano.Application.Courses;

public class CourseListItemDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Level { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
}

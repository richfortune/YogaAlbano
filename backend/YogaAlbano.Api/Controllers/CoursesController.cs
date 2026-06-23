using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YogaAlbano.Application.Courses;
using YogaAlbano.Infrastructure.Persistence;

namespace YogaAlbano.Api.Controllers;

[ApiController]
[Route("api/courses")]
public class CoursesController(YogaAlbanoDbContext dbContext) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<CourseListItemDto>>> GetCourses()
    {
        var courses = await dbContext.Courses
            .AsNoTracking()
            .Where(course => course.IsActive)
            .OrderBy(course => course.Name)
            .Select(course => new CourseListItemDto
            {
                Id = course.Id,
                Name = course.Name,
                Description = course.Description,
                Level = course.Level.ToString(),
                ImageUrl = course.ImageUrl
            })
            .ToListAsync();

        return Ok(courses);
    }
}

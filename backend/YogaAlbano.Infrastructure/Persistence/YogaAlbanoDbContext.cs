using Microsoft.EntityFrameworkCore;

namespace YogaAlbano.Infrastructure.Persistence;

public class YogaAlbanoDbContext(DbContextOptions<YogaAlbanoDbContext> options) : DbContext(options)
{
}

using Microsoft.EntityFrameworkCore;
using YogaAlbano.Domain.Entities;

namespace YogaAlbano.Infrastructure.Persistence;

public class YogaAlbanoDbContext(DbContextOptions<YogaAlbanoDbContext> options) : DbContext(options)
{
    public DbSet<AppUser> AppUsers => Set<AppUser>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Teacher> Teachers => Set<Teacher>();
    public DbSet<RecurringClassSchedule> RecurringClassSchedules => Set<RecurringClassSchedule>();
    public DbSet<YogaClass> YogaClasses => Set<YogaClass>();
    public DbSet<Booking> Bookings => Set<Booking>();
    public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();
    public DbSet<SubscriptionPlan> SubscriptionPlans => Set<SubscriptionPlan>();
    public DbSet<UserSubscription> UserSubscriptions => Set<UserSubscription>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(YogaAlbanoDbContext).Assembly);
    }
}

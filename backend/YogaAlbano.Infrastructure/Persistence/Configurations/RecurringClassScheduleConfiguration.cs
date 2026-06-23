using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YogaAlbano.Domain.Entities;

namespace YogaAlbano.Infrastructure.Persistence.Configurations;

public class RecurringClassScheduleConfiguration : IEntityTypeConfiguration<RecurringClassSchedule>
{
    public void Configure(EntityTypeBuilder<RecurringClassSchedule> builder)
    {
        builder.ToTable("RecurringClassSchedules");

        builder.HasKey(schedule => schedule.Id);

        builder.HasOne(schedule => schedule.Course)
            .WithMany(course => course.RecurringSchedules)
            .HasForeignKey(schedule => schedule.CourseId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(schedule => schedule.Teacher)
            .WithMany(teacher => teacher.RecurringSchedules)
            .HasForeignKey(schedule => schedule.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(schedule => schedule.GeneratedClasses)
            .WithOne(yogaClass => yogaClass.RecurringClassSchedule)
            .HasForeignKey(yogaClass => yogaClass.RecurringClassScheduleId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

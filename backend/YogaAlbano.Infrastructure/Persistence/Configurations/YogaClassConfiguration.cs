using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YogaAlbano.Domain.Entities;

namespace YogaAlbano.Infrastructure.Persistence.Configurations;

public class YogaClassConfiguration : IEntityTypeConfiguration<YogaClass>
{
    public void Configure(EntityTypeBuilder<YogaClass> builder)
    {
        builder.ToTable("YogaClasses");

        builder.HasKey(yogaClass => yogaClass.Id);

        builder.HasOne(yogaClass => yogaClass.Course)
            .WithMany(course => course.Classes)
            .HasForeignKey(yogaClass => yogaClass.CourseId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(yogaClass => yogaClass.Teacher)
            .WithMany(teacher => teacher.Classes)
            .HasForeignKey(yogaClass => yogaClass.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(yogaClass => yogaClass.RecurringClassSchedule)
            .WithMany(schedule => schedule.GeneratedClasses)
            .HasForeignKey(yogaClass => yogaClass.RecurringClassScheduleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(yogaClass => yogaClass.Bookings)
            .WithOne(booking => booking.YogaClass)
            .HasForeignKey(booking => booking.YogaClassId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

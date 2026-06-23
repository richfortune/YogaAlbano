using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YogaAlbano.Domain.Entities;

namespace YogaAlbano.Infrastructure.Persistence.Configurations;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("Courses");

        builder.HasKey(course => course.Id);

        builder.Property(course => course.Name)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(course => course.Description)
            .HasMaxLength(2000);

        builder.Property(course => course.ImageUrl)
            .HasMaxLength(1000);

        builder.Property(course => course.Level)
            .HasConversion<string>();

        builder.HasMany(course => course.RecurringSchedules)
            .WithOne(schedule => schedule.Course)
            .HasForeignKey(schedule => schedule.CourseId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(course => course.Classes)
            .WithOne(yogaClass => yogaClass.Course)
            .HasForeignKey(yogaClass => yogaClass.CourseId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

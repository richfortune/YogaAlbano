using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YogaAlbano.Domain.Entities;

namespace YogaAlbano.Infrastructure.Persistence.Configurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.ToTable("Teachers");

        builder.HasKey(teacher => teacher.Id);

        builder.Property(teacher => teacher.FirstName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(teacher => teacher.LastName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(teacher => teacher.Bio)
            .HasMaxLength(2000);

        builder.Property(teacher => teacher.PhotoUrl)
            .HasMaxLength(1000);

        builder.HasMany(teacher => teacher.RecurringSchedules)
            .WithOne(schedule => schedule.Teacher)
            .HasForeignKey(schedule => schedule.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(teacher => teacher.Classes)
            .WithOne(yogaClass => yogaClass.Teacher)
            .HasForeignKey(yogaClass => yogaClass.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

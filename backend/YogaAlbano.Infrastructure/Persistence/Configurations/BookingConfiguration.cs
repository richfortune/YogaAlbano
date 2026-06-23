using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YogaAlbano.Domain.Entities;

namespace YogaAlbano.Infrastructure.Persistence.Configurations;

public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.ToTable("Bookings");

        builder.HasKey(booking => booking.Id);

        builder.Property(booking => booking.Status)
            .HasConversion<string>();

        builder.HasIndex(booking => new { booking.AppUserId, booking.YogaClassId });

        builder.HasIndex(booking => new { booking.AppUserId, booking.YogaClassId })
            .IsUnique();

        builder.HasOne(booking => booking.AppUser)
            .WithMany(user => user.Bookings)
            .HasForeignKey(booking => booking.AppUserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(booking => booking.YogaClass)
            .WithMany(yogaClass => yogaClass.Bookings)
            .HasForeignKey(booking => booking.YogaClassId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

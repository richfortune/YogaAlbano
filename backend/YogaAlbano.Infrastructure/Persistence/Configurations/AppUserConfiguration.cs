using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YogaAlbano.Domain.Entities;

namespace YogaAlbano.Infrastructure.Persistence.Configurations;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.ToTable("AppUsers");

        builder.HasKey(user => user.Id);

        builder.Property(user => user.FirstName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(user => user.LastName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(user => user.Email)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(user => user.PasswordHash)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(user => user.PhoneNumber)
            .HasMaxLength(30);

        builder.Property(user => user.Status)
            .HasConversion<string>();

        builder.Property(user => user.Role)
            .HasConversion<string>();

        builder.HasIndex(user => user.Email)
            .IsUnique();

        builder.HasMany(user => user.Bookings)
            .WithOne(booking => booking.AppUser)
            .HasForeignKey(booking => booking.AppUserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(user => user.RefreshTokens)
            .WithOne(refreshToken => refreshToken.AppUser)
            .HasForeignKey(refreshToken => refreshToken.AppUserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(user => user.Subscriptions)
            .WithOne(subscription => subscription.AppUser)
            .HasForeignKey(subscription => subscription.AppUserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

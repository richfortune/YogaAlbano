using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YogaAlbano.Domain.Entities;

namespace YogaAlbano.Infrastructure.Persistence.Configurations;

public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> builder)
    {
        builder.ToTable("RefreshTokens");

        builder.HasKey(refreshToken => refreshToken.Id);

        builder.Property(refreshToken => refreshToken.TokenHash)
            .HasMaxLength(500)
            .IsRequired();

        builder.HasOne(refreshToken => refreshToken.AppUser)
            .WithMany(user => user.RefreshTokens)
            .HasForeignKey(refreshToken => refreshToken.AppUserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YogaAlbano.Domain.Entities;

namespace YogaAlbano.Infrastructure.Persistence.Configurations;

public class UserSubscriptionConfiguration : IEntityTypeConfiguration<UserSubscription>
{
    public void Configure(EntityTypeBuilder<UserSubscription> builder)
    {
        builder.ToTable("UserSubscriptions");

        builder.HasKey(subscription => subscription.Id);

        builder.Property(subscription => subscription.Status)
            .HasConversion<string>();

        builder.HasOne(subscription => subscription.AppUser)
            .WithMany(user => user.Subscriptions)
            .HasForeignKey(subscription => subscription.AppUserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(subscription => subscription.SubscriptionPlan)
            .WithMany()
            .HasForeignKey(subscription => subscription.SubscriptionPlanId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

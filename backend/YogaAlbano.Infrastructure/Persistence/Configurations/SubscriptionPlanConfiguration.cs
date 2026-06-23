using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YogaAlbano.Domain.Entities;

namespace YogaAlbano.Infrastructure.Persistence.Configurations;

public class SubscriptionPlanConfiguration : IEntityTypeConfiguration<SubscriptionPlan>
{
    public void Configure(EntityTypeBuilder<SubscriptionPlan> builder)
    {
        builder.ToTable("SubscriptionPlans");

        builder.HasKey(plan => plan.Id);

        builder.Property(plan => plan.Name)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(plan => plan.Description)
            .HasMaxLength(2000);

        builder.Property(plan => plan.Type)
            .HasConversion<string>();

        builder.Property(plan => plan.Price)
            .HasPrecision(10, 2);

        builder.HasIndex(plan => plan.Name);
    }
}

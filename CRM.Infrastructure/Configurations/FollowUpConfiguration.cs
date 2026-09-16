using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Configurations;

public class FollowUpConfiguration : IEntityTypeConfiguration<FollowUp>
{
    public void Configure(EntityTypeBuilder<FollowUp> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(1000);

        builder.HasOne(x => x.Customer)
            .WithMany(x => x.FollowUps)
            .HasForeignKey(x => x.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x => x.AssignedUser)
    .WithMany(x => x.FollowUps)
    .HasForeignKey(x => x.AssignedUserId)
    .OnDelete(DeleteBehavior.SetNull);
    }
}
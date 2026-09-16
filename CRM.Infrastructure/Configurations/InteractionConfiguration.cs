using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Configurations;

public class InteractionConfiguration
    : IEntityTypeConfiguration<Interaction>
{
    public void Configure(EntityTypeBuilder<Interaction> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Subject)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(1000);

        builder.Property(x => x.Result)
            .HasMaxLength(1000);

        builder.HasOne(x => x.Customer)
            .WithMany(x => x.Interactions)
            .HasForeignKey(x => x.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.CreatedByUser)
    .WithMany(x => x.Interactions)
    .HasForeignKey(x => x.CreatedByUserId)
    .OnDelete(DeleteBehavior.SetNull);
    }
}
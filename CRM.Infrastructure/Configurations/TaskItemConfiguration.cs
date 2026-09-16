using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Configurations;

public class TaskItemConfiguration
    : IEntityTypeConfiguration<TaskItem>
{
    public void Configure(EntityTypeBuilder<TaskItem> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(1000);

        builder.HasOne(x => x.Customer)
            .WithMany(x => x.Tasks)
            .HasForeignKey(x => x.CustomerId)
            .OnDelete(DeleteBehavior.SetNull);
        builder.HasOne(x => x.AssignedUser)
    .WithMany(x => x.Tasks)
    .HasForeignKey(x => x.AssignedUserId)
    .OnDelete(DeleteBehavior.SetNull);
    }
}
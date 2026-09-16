using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.UserName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.FullName)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.PasswordHash)
            .HasMaxLength(500)
            .IsRequired();

        builder.HasIndex(x => x.UserName)
            .IsUnique();
    }
}
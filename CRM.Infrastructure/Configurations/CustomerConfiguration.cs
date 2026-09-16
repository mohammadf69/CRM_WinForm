using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FirstName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.LastName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.NationalCode)
            .HasMaxLength(10);

        builder.Property(x => x.Mobile)
            .HasMaxLength(20);

        builder.Property(x => x.Phone)
            .HasMaxLength(20);

        builder.Property(x => x.Email)
            .HasMaxLength(150);

        builder.Property(x => x.Address)
            .HasMaxLength(500);

        builder.HasOne(x => x.Company)
            .WithMany(x => x.Customers)
            .HasForeignKey(x => x.CompanyId)
            .OnDelete(DeleteBehavior.SetNull);
        builder.HasOne(x => x.AssignedUser)
    .WithMany(x => x.Customers)
    .HasForeignKey(x => x.AssignedUserId)
    .OnDelete(DeleteBehavior.SetNull);
    }
}
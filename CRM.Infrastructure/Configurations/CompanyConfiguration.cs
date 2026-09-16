using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Configurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.EconomicCode)
            .HasMaxLength(20);

        builder.Property(x => x.Phone)
            .HasMaxLength(20);

        builder.Property(x => x.Address)
            .HasMaxLength(500);
    }
}
using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>

{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.ProductCode);

        builder.Property(x => x.Name)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.CurrentUnitPrice)
            .HasColumnType("decimal(18,2)");

        builder.Property(x => x.StockQuantity)
            .HasColumnType("decimal(18,3)");
    }
}
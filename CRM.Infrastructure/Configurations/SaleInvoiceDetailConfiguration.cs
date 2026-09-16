using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Configurations;

public class SaleInvoiceDetailConfiguration : IEntityTypeConfiguration<SaleInvoiceDetail>
{
    public void Configure(EntityTypeBuilder<SaleInvoiceDetail> builder)
    {
        builder.HasKey(x => new
        {
            x.Year,
            x.InvoiceCode,
            x.ProductCode,
            x.LineNumber
        });

        builder.HasOne(x => x.Invoice)
            .WithMany(x => x.Details)
            .HasForeignKey(x => new
            {
                x.Year,
                x.InvoiceCode
            })
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Product)
            .WithMany(x => x.InvoiceDetails)
            .HasForeignKey(x => x.ProductCode)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.UnitPrice)
            .HasColumnType("decimal(18,2)");

        builder.Property(x => x.TotalPrice)
            .HasColumnType("decimal(18,2)");

        builder.Property(x => x.Quantity)
            .HasColumnType("decimal(18,3)");
    }
}
using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Configurations;

public class SaleInvoiceConfiguration
    : IEntityTypeConfiguration<SaleInvoice>
{
    public void Configure(EntityTypeBuilder<SaleInvoice> builder)
    {
        builder.HasKey(x => new
        {
            x.Year,
            x.InvoiceCode
        });

        builder.Property(x => x.Description)
            .HasMaxLength(500);

        builder.HasOne(x => x.Customer)
            .WithMany(x => x.SaleInvoices)
            .HasForeignKey(x => x.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
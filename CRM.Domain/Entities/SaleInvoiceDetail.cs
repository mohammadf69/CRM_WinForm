namespace CRM.Domain.Entities;

public class SaleInvoiceDetail
{
    public short Year { get; set; }

    public int InvoiceCode { get; set; }

    public int ProductCode { get; set; }

    public int LineNumber { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal TotalPrice { get; set; }

    public SaleInvoice Invoice { get; set; } = null!;

    public Product Product { get; set; } = null!;
}
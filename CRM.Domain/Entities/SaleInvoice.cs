namespace CRM.Domain.Entities;

public class SaleInvoice
{
    public short Year { get; set; }

    public int InvoiceCode { get; set; }

    public int CustomerId { get; set; }

    public DateTime InvoiceDate { get; set; }

    public string? Description { get; set; }

    public Customer Customer { get; set; } = null!;

    public ICollection<SaleInvoiceDetail> Details { get; set; }
        = new List<SaleInvoiceDetail>();
}
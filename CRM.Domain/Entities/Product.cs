namespace CRM.Domain.Entities;

public class Product
{
    public int ProductCode { get; set; }

    public required string Name { get; set; }

    public decimal CurrentUnitPrice { get; set; }

    public decimal StockQuantity { get; set; }

    public bool IsActive { get; set; }

    public ICollection<SaleInvoiceDetail> InvoiceDetails { get; set; }
        = new List<SaleInvoiceDetail>();
}
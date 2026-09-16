namespace CRM.Domain.Entities;

public class Company
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public string? EconomicCode { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public ICollection<Customer> Customers { get; set; }
        = new List<Customer>();
}
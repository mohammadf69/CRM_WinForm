namespace CRM.Application.DTOs.Customers;

public class CreateCustomerDto
{
    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public string? NationalCode { get; set; }

    public string? Mobile { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public int? CompanyId { get; set; }

    public int? AssignedUserId { get; set; }
}
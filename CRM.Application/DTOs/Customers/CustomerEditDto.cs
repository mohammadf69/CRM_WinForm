namespace CRM.Application.DTOs.Customers;

public class CustomerEditDto
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? NationalCode { get; set; }

    public string? Mobile { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public int? CompanyId { get; set; }

    public int? AssignedUserId { get; set; }

    public bool IsActive { get; set; }
}
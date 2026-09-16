using CRM.Domain.Entities;

public class Customer : BaseEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public string? NationalCode { get; set; }
    public string? Mobile { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public bool IsActive { get; set; }

    public int? CompanyId { get; set; }
    public Company? Company { get; set; }

    public int? AssignedUserId { get; set; }
    public User? AssignedUser { get; set; }

    public ICollection<SaleInvoice> SaleInvoices { get; set; }
        = new List<SaleInvoice>();

    public ICollection<Interaction> Interactions { get; set; }
        = new List<Interaction>();

    public ICollection<FollowUp> FollowUps { get; set; }
        = new List<FollowUp>();

    public ICollection<TaskItem> Tasks { get; set; }
        = new List<TaskItem>();
}
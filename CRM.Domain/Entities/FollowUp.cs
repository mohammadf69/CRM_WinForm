namespace CRM.Domain.Entities;

public class FollowUp
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public DateTime DueDate { get; set; }

    public required string Title { get; set; }

    public string? Description { get; set; }

    public FollowUpStatus Status { get; set; }

    public Customer Customer { get; set; } = null!;
    public int? AssignedUserId { get; set; }
    public User? AssignedUser { get; set; }
}
public enum FollowUpStatus : byte
{
    Pending = 1,
    Completed = 2,
    Cancelled = 3
}
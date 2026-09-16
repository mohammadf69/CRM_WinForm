namespace CRM.Domain.Entities;

public class TaskItem
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public required string Title { get; set; }

    public string? Description { get; set; }

    public DateTime? DueDate { get; set; }

    public TaskPriority Priority { get; set; }

    public TaskStatus Status { get; set; }

    public Customer? Customer { get; set; }
    public int? AssignedUserId { get; set; }

    public User? AssignedUser { get; set; }
}
public enum TaskStatus : byte
{
    Open = 1,
    InProgress = 2,
    Completed = 3,
    Cancelled = 4
}
public enum TaskPriority : byte
{
    Low = 1,
    Medium = 2,
    High = 3
}
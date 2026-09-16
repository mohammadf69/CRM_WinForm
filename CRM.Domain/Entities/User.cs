namespace CRM.Domain.Entities;

public class User
{
    public int Id { get; set; }

    public required string UserName { get; set; }

    public required string FullName { get; set; }

    public required string PasswordHash { get; set; }

    public bool IsActive { get; set; }

    public ICollection<Customer> Customers { get; set; }
        = new List<Customer>();

    public ICollection<Interaction> Interactions { get; set; }
        = new List<Interaction>();

    public ICollection<FollowUp> FollowUps { get; set; }
        = new List<FollowUp>();

    public ICollection<TaskItem> Tasks { get; set; }
        = new List<TaskItem>();
}
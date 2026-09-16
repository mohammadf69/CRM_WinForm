namespace CRM.Domain.Entities;

public class Interaction
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public DateTime InteractionDate { get; set; }

    public InteractionType Type { get; set; }

    public required string Subject { get; set; }

    public string? Description { get; set; }

    public string? Result { get; set; }

    public Customer Customer { get; set; } = null!;
    public int? CreatedByUserId { get; set; }

    public User? CreatedByUser { get; set; }
}


public enum InteractionType : byte
{
    PhoneCall = 1,
    Meeting = 2,
    Email = 3,
    Message = 4
}
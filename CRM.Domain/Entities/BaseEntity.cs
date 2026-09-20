namespace CRM.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
    public byte[] RowVersion { get; set; } = [];
}
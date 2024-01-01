using System.ComponentModel.DataAnnotations;

namespace DataAccess;

public record Service
{
    [Key]
    public Guid Id { get; init; } = Guid.NewGuid();
    [MaxLength(64)]
    public required string Name { get; init; }
    public required float Price { get; init; }
}

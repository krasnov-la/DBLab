using System.ComponentModel.DataAnnotations;

namespace DataAccess;

public record Client
{
    [Key]
    public Guid Id { get; init; } = Guid.NewGuid();
    [MaxLength(64)]
    public required string Name { get; init; }
    [MaxLength(64)]
    public required string Surname { get; init; }
}

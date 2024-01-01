using System.ComponentModel.DataAnnotations;

namespace DataAccess;

public record Role
{
    [Key]
    public Guid Id { get; init; } = Guid.NewGuid();
    [MaxLength(64)]
    public required string Name { get; init; }
    public required float Salary { get; init; }
    public required bool IsMech { get; init; }
}
